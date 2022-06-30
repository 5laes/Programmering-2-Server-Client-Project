using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_Server
{
    public partial class ServerForm : Form
    {
        private Socket _serverSocket, _clientSocket; //skapar en klientsocket och en serversocket
        private byte[] _buffer;

        public ServerForm()
        {
            InitializeComponent();
        }

        //startar servern
        private void BTNStartServer_Click(object sender, EventArgs e)
        {
            StartServer();
            InfoTxtBox.Text = "No client is connected";
        }

        //tar bort alla object ur listan
        private void BTNRemoveAllObject_Click(object sender, EventArgs e)
        {
            try
            {
                RecivedBookListBox.Items.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("The list is already empthy!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //tarbort markerat object ur listan
        private void BTNRemoveSelectObject_Click(object sender, EventArgs e)
        {
            try
            {
                RecivedBookListBox.Items.RemoveAt(RecivedBookListBox.SelectedIndex);
            }
            catch (Exception)
            {
                MessageBox.Show("You have not selected an object!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }            

        //startar servern och gör den redo att acceptera information
        private void StartServer()
        {
            try
            {
                _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _serverSocket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12345));
                _serverSocket.Listen(0);
                _serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
                BTNStartServer.BackColor = Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Gör server redo att ta emot infomation
        private void AcceptCallback(IAsyncResult AR)
        {
            try
            {
                _clientSocket = _serverSocket.EndAccept(AR);                
                _buffer = new byte[_clientSocket.ReceiveBufferSize];
                _clientSocket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), null);
                _serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
                //Denna sista rad gör så man kan reconnecta till servern om man disconnectar

                MethodInvoker invoker = new MethodInvoker(delegate
                {
                    InfoTxtBox.Text = "A client is connected";
                });
                this.Invoke(invoker);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Här tar servern emot information
        //När servern får information så hanteras det här
        //Servern blir redo att få ny information igen
        private void ReceiveCallback(IAsyncResult AR)
        {
            try
            {
                int received = _clientSocket.EndReceive(AR);

                /*denna if gör att texten inte glitchar när avbryter
                 kopplingen till servern*/
                if (received == 0)
                {
                    MethodInvoker invoker = new MethodInvoker(delegate
                    {
                        InfoTxtBox.Text = "No client is connected";
                    });
                    this.Invoke(invoker);
                    return;
                }

                Array.Resize(ref _buffer, received);
                string text = Encoding.ASCII.GetString(_buffer);
                AddItemToListBox(text);
                Array.Resize(ref _buffer, _clientSocket.ReceiveBufferSize);
                _clientSocket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNExportToFile_Click(object sender, EventArgs e)
        {
            string currentTime = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss");
            using (StreamWriter text = new StreamWriter($"Rapport_{currentTime}.txt", true))
            {
                foreach (var item in RecivedBookListBox.Items)
                {
                    text.Write(item.ToString() + "\n");
                }
            }
        }

        //lägger till objeten som servern tar emot i listboxen direkt
        private void AddItemToListBox(string text)
        {
            MethodInvoker invoker = new MethodInvoker(delegate 
            {
                RecivedBookListBox.Items.Add(text);
            });

            this.Invoke(invoker);
        }
    }
}
