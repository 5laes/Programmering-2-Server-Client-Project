using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avdelningsrapport
{
    public delegate void AddBookDelegate(Book book);
    public partial class ClientForm : Form
    {
        private Socket _clientSocket; // skapar en clientsocket
        private readonly List<Book> newBook = new List<Book>();
        readonly FileLoader fileLoader = new FileLoader();

        public ClientForm()
        {
            InitializeComponent();
            if (!fileLoader.ReadFile())
            {
                BookListBox.Items.Add("File Missing!");
            }
            newBook = fileLoader.CreateBooks();
        }

        // Detta gör att man inte får error när man kryssar clientfönstret
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            if (_clientSocket != null && _clientSocket.Connected)
            {
                _clientSocket.Close();
            }
        }

        //kopplar sig till en server med specifikt ip och port nummer
        private void BTNConnectServer_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(PortTxtBox.Text, out int port);
                _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _clientSocket.BeginConnect(new IPEndPoint(IPAddress.Parse(IPTxtBox.Text), port), new AsyncCallback(ConnectCallback), null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        // går igenom alla object i listan och skickar dem som bytes
        private void BTNSendAllObjects_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in BookListBox.Items)
                {
                    byte[] buffer = Encoding.ASCII.GetBytes(item.ToString());
                    _clientSocket.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(SendCallback), null);
                    Thread.Sleep(5);
                    /*Utan denna Thread.Sleep så skickas många object som ett object.
                     försökte lösa det med await men lyckades inte hitta något som funkade
                     känns inte om att Thread.Sleep är en bra lösning och vad jag har läst 
                     så är det ingen bra lösning häller*/
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //läser in alla böcker till listboxen
        private void BTNLoadList_Click(object sender, EventArgs e)
        {
            try
            {
                BookListBox.Items.Clear();
                foreach (var item in newBook)
                {
                    BookListBox.Items.Add(item.ToString());
                }
                BTNClearList.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //feedback när man lyckas koppla till en server
        private void ConnectCallback(IAsyncResult AR)
        {
            try
            {
                _clientSocket.EndConnect(AR);
                //BTNSendAllObjects.Enabled = true;
                //BTNSendSelectObject.Enabled = true;
                MethodInvoker invoker = new MethodInvoker(delegate
                {
                    BTNSendAllObjects.Enabled = true;
                    BTNSendSelectObject.Enabled = true;
                    BTNDisconnect.Enabled = true;
                });

                this.Invoke(invoker);
                /*försökte göra dessa knappar bara klickbara efter man har connectat
                 till servern men får bara threading error när jag gör det här.
                lyckas inte lösa det. skulle man sätta detta i BTNConnectServer_click metoden
                så funkar det utan problem.*/

                /*Fick löst det med en invoker men vet inte om det är en bra lösning*/
                BTNConnectServer.BackColor = Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //avslutar en sändning när den har tagits emot av servern
        private void SendCallback(IAsyncResult AR)
        {
            _clientSocket.EndSend(AR);
        }

        //avlsutar en påbörjad bortkoppling
        private void EndCallback(IAsyncResult AR)
        {
            _clientSocket.EndDisconnect(AR);
        }

        // skickar markerat object i listan
        private void BTNSendSelectObject_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] buffer = Encoding.ASCII.GetBytes(BookListBox.SelectedItem.ToString());
                /*Försöker man skicka ett objekt utan att markera något blir det fel här
                 det fångas inte av "catch" förstår inte varför*/
                _clientSocket.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(SendCallback), null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //kopplar ifrån från server
        private void BTNDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                //påbörjar en bortkoppling
                _clientSocket.BeginDisconnect(false, new AsyncCallback(EndCallback), null);
                BTNConnectServer.BackColor = Color.Transparent;
                BTNDisconnect.Enabled = false;
                BTNSendAllObjects.Enabled = false;
                BTNSendSelectObject.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void BTNClearList_Click(object sender, EventArgs e)
        {
            BookListBox.Items.Clear();
            BTNClearList.Enabled = false;
        }

        private void BTNAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm bookForm = new AddBookForm();
            bookForm.addBookCallback = new AddBookDelegate(this.AddBookCallback);
            bookForm.ShowDialog();
        }

        private void AddBookCallback(Book book)
        {
            BookListBox.Items.Add(book.ToString());
        }
    }
}
