
namespace Avdelningsrapport
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BookListBox = new System.Windows.Forms.ListBox();
            this.BTNLoadList = new System.Windows.Forms.Button();
            this.BTNSendSelectObject = new System.Windows.Forms.Button();
            this.BTNAddBook = new System.Windows.Forms.Button();
            this.BTNSendAllObjects = new System.Windows.Forms.Button();
            this.BTNConnectServer = new System.Windows.Forms.Button();
            this.PortTxtBox = new System.Windows.Forms.TextBox();
            this.AddressLable = new System.Windows.Forms.Label();
            this.IPTxtBox = new System.Windows.Forms.TextBox();
            this.PortLable = new System.Windows.Forms.Label();
            this.BTNDisconnect = new System.Windows.Forms.Button();
            this.BTNClearList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BookListBox
            // 
            this.BookListBox.FormattingEnabled = true;
            this.BookListBox.Location = new System.Drawing.Point(12, 12);
            this.BookListBox.Name = "BookListBox";
            this.BookListBox.Size = new System.Drawing.Size(530, 459);
            this.BookListBox.TabIndex = 0;
            // 
            // BTNLoadList
            // 
            this.BTNLoadList.Location = new System.Drawing.Point(12, 477);
            this.BTNLoadList.Name = "BTNLoadList";
            this.BTNLoadList.Size = new System.Drawing.Size(81, 52);
            this.BTNLoadList.TabIndex = 1;
            this.BTNLoadList.Text = "Load List";
            this.BTNLoadList.UseVisualStyleBackColor = true;
            this.BTNLoadList.Click += new System.EventHandler(this.BTNLoadList_Click);
            // 
            // BTNSendSelectObject
            // 
            this.BTNSendSelectObject.Enabled = false;
            this.BTNSendSelectObject.Location = new System.Drawing.Point(99, 506);
            this.BTNSendSelectObject.Name = "BTNSendSelectObject";
            this.BTNSendSelectObject.Size = new System.Drawing.Size(136, 23);
            this.BTNSendSelectObject.TabIndex = 3;
            this.BTNSendSelectObject.Text = "Send selected object";
            this.BTNSendSelectObject.UseVisualStyleBackColor = true;
            this.BTNSendSelectObject.Click += new System.EventHandler(this.BTNSendSelectObject_Click);
            // 
            // BTNAddBook
            // 
            this.BTNAddBook.Location = new System.Drawing.Point(99, 535);
            this.BTNAddBook.Name = "BTNAddBook";
            this.BTNAddBook.Size = new System.Drawing.Size(136, 23);
            this.BTNAddBook.TabIndex = 4;
            this.BTNAddBook.Text = "Add a new Book";
            this.BTNAddBook.UseVisualStyleBackColor = true;
            this.BTNAddBook.Click += new System.EventHandler(this.BTNAddBook_Click);
            // 
            // BTNSendAllObjects
            // 
            this.BTNSendAllObjects.Enabled = false;
            this.BTNSendAllObjects.Location = new System.Drawing.Point(99, 477);
            this.BTNSendAllObjects.Name = "BTNSendAllObjects";
            this.BTNSendAllObjects.Size = new System.Drawing.Size(136, 23);
            this.BTNSendAllObjects.TabIndex = 2;
            this.BTNSendAllObjects.Text = "Send all objects";
            this.BTNSendAllObjects.UseVisualStyleBackColor = true;
            this.BTNSendAllObjects.Click += new System.EventHandler(this.BTNSendAllObjects_Click);
            // 
            // BTNConnectServer
            // 
            this.BTNConnectServer.Location = new System.Drawing.Point(461, 477);
            this.BTNConnectServer.Name = "BTNConnectServer";
            this.BTNConnectServer.Size = new System.Drawing.Size(81, 52);
            this.BTNConnectServer.TabIndex = 5;
            this.BTNConnectServer.Text = "Connect ot server";
            this.BTNConnectServer.UseVisualStyleBackColor = true;
            this.BTNConnectServer.Click += new System.EventHandler(this.BTNConnectServer_Click);
            // 
            // PortTxtBox
            // 
            this.PortTxtBox.Location = new System.Drawing.Point(355, 535);
            this.PortTxtBox.Name = "PortTxtBox";
            this.PortTxtBox.Size = new System.Drawing.Size(100, 20);
            this.PortTxtBox.TabIndex = 6;
            this.PortTxtBox.Text = "12345";
            // 
            // AddressLable
            // 
            this.AddressLable.AutoSize = true;
            this.AddressLable.Location = new System.Drawing.Point(352, 477);
            this.AddressLable.Name = "AddressLable";
            this.AddressLable.Size = new System.Drawing.Size(61, 13);
            this.AddressLable.TabIndex = 7;
            this.AddressLable.Text = "IP Address:";
            // 
            // IPTxtBox
            // 
            this.IPTxtBox.Location = new System.Drawing.Point(355, 493);
            this.IPTxtBox.Name = "IPTxtBox";
            this.IPTxtBox.Size = new System.Drawing.Size(100, 20);
            this.IPTxtBox.TabIndex = 8;
            this.IPTxtBox.Text = "127.0.0.1";
            // 
            // PortLable
            // 
            this.PortLable.AutoSize = true;
            this.PortLable.Location = new System.Drawing.Point(355, 520);
            this.PortLable.Name = "PortLable";
            this.PortLable.Size = new System.Drawing.Size(29, 13);
            this.PortLable.TabIndex = 9;
            this.PortLable.Text = "Port:";
            // 
            // BTNDisconnect
            // 
            this.BTNDisconnect.Enabled = false;
            this.BTNDisconnect.Location = new System.Drawing.Point(461, 532);
            this.BTNDisconnect.Name = "BTNDisconnect";
            this.BTNDisconnect.Size = new System.Drawing.Size(81, 26);
            this.BTNDisconnect.TabIndex = 10;
            this.BTNDisconnect.Text = "Disconnect";
            this.BTNDisconnect.UseVisualStyleBackColor = true;
            this.BTNDisconnect.Click += new System.EventHandler(this.BTNDisconnect_Click);
            // 
            // BTNClearList
            // 
            this.BTNClearList.Enabled = false;
            this.BTNClearList.Location = new System.Drawing.Point(12, 532);
            this.BTNClearList.Name = "BTNClearList";
            this.BTNClearList.Size = new System.Drawing.Size(81, 26);
            this.BTNClearList.TabIndex = 11;
            this.BTNClearList.Text = "Clear list";
            this.BTNClearList.UseVisualStyleBackColor = true;
            this.BTNClearList.Click += new System.EventHandler(this.BTNClearList_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 570);
            this.Controls.Add(this.BTNClearList);
            this.Controls.Add(this.BTNDisconnect);
            this.Controls.Add(this.PortLable);
            this.Controls.Add(this.IPTxtBox);
            this.Controls.Add(this.AddressLable);
            this.Controls.Add(this.PortTxtBox);
            this.Controls.Add(this.BTNConnectServer);
            this.Controls.Add(this.BTNSendAllObjects);
            this.Controls.Add(this.BTNAddBook);
            this.Controls.Add(this.BTNSendSelectObject);
            this.Controls.Add(this.BTNLoadList);
            this.Controls.Add(this.BookListBox);
            this.MaximumSize = new System.Drawing.Size(570, 609);
            this.MinimumSize = new System.Drawing.Size(570, 609);
            this.Name = "ClientForm";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox BookListBox;
        private System.Windows.Forms.Button BTNLoadList;
        private System.Windows.Forms.Button BTNSendSelectObject;
        private System.Windows.Forms.Button BTNAddBook;
        private System.Windows.Forms.Button BTNSendAllObjects;
        private System.Windows.Forms.Button BTNConnectServer;
        private System.Windows.Forms.TextBox PortTxtBox;
        private System.Windows.Forms.Label AddressLable;
        private System.Windows.Forms.TextBox IPTxtBox;
        private System.Windows.Forms.Label PortLable;
        private System.Windows.Forms.Button BTNDisconnect;
        private System.Windows.Forms.Button BTNClearList;
    }
}

