
namespace TCP_Server
{
    partial class ServerForm
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
            this.RecivedBookListBox = new System.Windows.Forms.ListBox();
            this.BTNStartServer = new System.Windows.Forms.Button();
            this.BTNRemoveSelectObject = new System.Windows.Forms.Button();
            this.BTNRemoveAllObject = new System.Windows.Forms.Button();
            this.BTNExportToFile = new System.Windows.Forms.Button();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.PortLabel = new System.Windows.Forms.Label();
            this.InfoTxtBox = new System.Windows.Forms.TextBox();
            this.InfoLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RecivedBookListBox
            // 
            this.RecivedBookListBox.FormattingEnabled = true;
            this.RecivedBookListBox.Location = new System.Drawing.Point(12, 12);
            this.RecivedBookListBox.Name = "RecivedBookListBox";
            this.RecivedBookListBox.Size = new System.Drawing.Size(530, 459);
            this.RecivedBookListBox.TabIndex = 0;
            // 
            // BTNStartServer
            // 
            this.BTNStartServer.Location = new System.Drawing.Point(12, 477);
            this.BTNStartServer.Name = "BTNStartServer";
            this.BTNStartServer.Size = new System.Drawing.Size(82, 82);
            this.BTNStartServer.TabIndex = 1;
            this.BTNStartServer.Text = "Start server";
            this.BTNStartServer.UseVisualStyleBackColor = true;
            this.BTNStartServer.Click += new System.EventHandler(this.BTNStartServer_Click);
            // 
            // BTNRemoveSelectObject
            // 
            this.BTNRemoveSelectObject.Location = new System.Drawing.Point(100, 521);
            this.BTNRemoveSelectObject.Name = "BTNRemoveSelectObject";
            this.BTNRemoveSelectObject.Size = new System.Drawing.Size(134, 38);
            this.BTNRemoveSelectObject.TabIndex = 3;
            this.BTNRemoveSelectObject.Text = "Remove Selected Object";
            this.BTNRemoveSelectObject.UseVisualStyleBackColor = true;
            this.BTNRemoveSelectObject.Click += new System.EventHandler(this.BTNRemoveSelectObject_Click);
            // 
            // BTNRemoveAllObject
            // 
            this.BTNRemoveAllObject.Location = new System.Drawing.Point(100, 477);
            this.BTNRemoveAllObject.Name = "BTNRemoveAllObject";
            this.BTNRemoveAllObject.Size = new System.Drawing.Size(134, 38);
            this.BTNRemoveAllObject.TabIndex = 2;
            this.BTNRemoveAllObject.Text = "Remove all objects";
            this.BTNRemoveAllObject.UseVisualStyleBackColor = true;
            this.BTNRemoveAllObject.Click += new System.EventHandler(this.BTNRemoveAllObject_Click);
            // 
            // BTNExportToFile
            // 
            this.BTNExportToFile.Location = new System.Drawing.Point(240, 477);
            this.BTNExportToFile.Name = "BTNExportToFile";
            this.BTNExportToFile.Size = new System.Drawing.Size(132, 82);
            this.BTNExportToFile.TabIndex = 4;
            this.BTNExportToFile.Text = "Export to textfile";
            this.BTNExportToFile.UseVisualStyleBackColor = true;
            this.BTNExportToFile.Click += new System.EventHandler(this.BTNExportToFile_Click);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(379, 478);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(96, 13);
            this.AddressLabel.TabIndex = 5;
            this.AddressLabel.Text = "Address: 127.0.0.1";
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(378, 491);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(62, 13);
            this.PortLabel.TabIndex = 6;
            this.PortLabel.Text = "Port: 12345";
            // 
            // InfoTxtBox
            // 
            this.InfoTxtBox.Location = new System.Drawing.Point(382, 539);
            this.InfoTxtBox.Name = "InfoTxtBox";
            this.InfoTxtBox.ReadOnly = true;
            this.InfoTxtBox.Size = new System.Drawing.Size(160, 20);
            this.InfoTxtBox.TabIndex = 7;
            // 
            // InfoLable
            // 
            this.InfoLable.AutoSize = true;
            this.InfoLable.Location = new System.Drawing.Point(382, 521);
            this.InfoLable.Name = "InfoLable";
            this.InfoLable.Size = new System.Drawing.Size(28, 13);
            this.InfoLable.TabIndex = 8;
            this.InfoLable.Text = "Info:";
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 571);
            this.Controls.Add(this.InfoLable);
            this.Controls.Add(this.InfoTxtBox);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.BTNExportToFile);
            this.Controls.Add(this.BTNRemoveAllObject);
            this.Controls.Add(this.BTNRemoveSelectObject);
            this.Controls.Add(this.BTNStartServer);
            this.Controls.Add(this.RecivedBookListBox);
            this.MaximumSize = new System.Drawing.Size(570, 610);
            this.MinimumSize = new System.Drawing.Size(570, 610);
            this.Name = "ServerForm";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox RecivedBookListBox;
        private System.Windows.Forms.Button BTNStartServer;
        private System.Windows.Forms.Button BTNRemoveSelectObject;
        private System.Windows.Forms.Button BTNRemoveAllObject;
        private System.Windows.Forms.Button BTNExportToFile;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox InfoTxtBox;
        private System.Windows.Forms.Label InfoLable;
    }
}

