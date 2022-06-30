
namespace Avdelningsrapport
{
    partial class AddBookForm
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
            this.TitleLable = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.WritherLabel = new System.Windows.Forms.Label();
            this.WriterTextBox = new System.Windows.Forms.TextBox();
            this.GenreLable = new System.Windows.Forms.Label();
            this.BTNNovell = new System.Windows.Forms.Button();
            this.BTNRoman = new System.Windows.Forms.Button();
            this.BTNTidskrift = new System.Windows.Forms.Button();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.ChosenGenreLable = new System.Windows.Forms.Label();
            this.BTNAddBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLable
            // 
            this.TitleLable.AutoSize = true;
            this.TitleLable.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TitleLable.Location = new System.Drawing.Point(13, 13);
            this.TitleLable.Name = "TitleLable";
            this.TitleLable.Size = new System.Drawing.Size(27, 13);
            this.TitleLable.TabIndex = 0;
            this.TitleLable.Text = "Title";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(12, 29);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.TitleTextBox.TabIndex = 1;
            // 
            // WritherLabel
            // 
            this.WritherLabel.AutoSize = true;
            this.WritherLabel.Location = new System.Drawing.Point(118, 12);
            this.WritherLabel.Name = "WritherLabel";
            this.WritherLabel.Size = new System.Drawing.Size(35, 13);
            this.WritherLabel.TabIndex = 2;
            this.WritherLabel.Text = "Writer";
            // 
            // WriterTextBox
            // 
            this.WriterTextBox.Location = new System.Drawing.Point(118, 29);
            this.WriterTextBox.Name = "WriterTextBox";
            this.WriterTextBox.Size = new System.Drawing.Size(100, 20);
            this.WriterTextBox.TabIndex = 3;
            // 
            // GenreLable
            // 
            this.GenreLable.AutoSize = true;
            this.GenreLable.Location = new System.Drawing.Point(10, 73);
            this.GenreLable.Name = "GenreLable";
            this.GenreLable.Size = new System.Drawing.Size(36, 13);
            this.GenreLable.TabIndex = 5;
            this.GenreLable.Text = "Genre";
            // 
            // BTNNovell
            // 
            this.BTNNovell.Location = new System.Drawing.Point(12, 89);
            this.BTNNovell.Name = "BTNNovell";
            this.BTNNovell.Size = new System.Drawing.Size(75, 23);
            this.BTNNovell.TabIndex = 6;
            this.BTNNovell.Text = "Novell";
            this.BTNNovell.UseVisualStyleBackColor = true;
            this.BTNNovell.Click += new System.EventHandler(this.BTNNovell_Click);
            // 
            // BTNRoman
            // 
            this.BTNRoman.Location = new System.Drawing.Point(12, 118);
            this.BTNRoman.Name = "BTNRoman";
            this.BTNRoman.Size = new System.Drawing.Size(75, 23);
            this.BTNRoman.TabIndex = 7;
            this.BTNRoman.Text = "Roman";
            this.BTNRoman.UseVisualStyleBackColor = true;
            this.BTNRoman.Click += new System.EventHandler(this.BTNRoman_Click);
            // 
            // BTNTidskrift
            // 
            this.BTNTidskrift.Location = new System.Drawing.Point(13, 147);
            this.BTNTidskrift.Name = "BTNTidskrift";
            this.BTNTidskrift.Size = new System.Drawing.Size(75, 23);
            this.BTNTidskrift.TabIndex = 8;
            this.BTNTidskrift.Text = "Tidskrift";
            this.BTNTidskrift.UseVisualStyleBackColor = true;
            this.BTNTidskrift.Click += new System.EventHandler(this.BTNTidskrift_Click);
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(118, 92);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.ReadOnly = true;
            this.GenreTextBox.Size = new System.Drawing.Size(100, 20);
            this.GenreTextBox.TabIndex = 9;
            // 
            // ChosenGenreLable
            // 
            this.ChosenGenreLable.AutoSize = true;
            this.ChosenGenreLable.Location = new System.Drawing.Point(118, 73);
            this.ChosenGenreLable.Name = "ChosenGenreLable";
            this.ChosenGenreLable.Size = new System.Drawing.Size(73, 13);
            this.ChosenGenreLable.TabIndex = 10;
            this.ChosenGenreLable.Text = "Chosen genre";
            // 
            // BTNAddBook
            // 
            this.BTNAddBook.Location = new System.Drawing.Point(143, 147);
            this.BTNAddBook.Name = "BTNAddBook";
            this.BTNAddBook.Size = new System.Drawing.Size(75, 23);
            this.BTNAddBook.TabIndex = 11;
            this.BTNAddBook.Text = "Add book";
            this.BTNAddBook.UseVisualStyleBackColor = true;
            this.BTNAddBook.Click += new System.EventHandler(this.BTNAddBook_Click);
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 186);
            this.Controls.Add(this.BTNAddBook);
            this.Controls.Add(this.ChosenGenreLable);
            this.Controls.Add(this.GenreTextBox);
            this.Controls.Add(this.BTNTidskrift);
            this.Controls.Add(this.BTNRoman);
            this.Controls.Add(this.BTNNovell);
            this.Controls.Add(this.GenreLable);
            this.Controls.Add(this.WriterTextBox);
            this.Controls.Add(this.WritherLabel);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.TitleLable);
            this.MaximumSize = new System.Drawing.Size(248, 225);
            this.MinimumSize = new System.Drawing.Size(248, 225);
            this.Name = "AddBookForm";
            this.Text = "Add book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLable;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label WritherLabel;
        private System.Windows.Forms.TextBox WriterTextBox;
        private System.Windows.Forms.Label GenreLable;
        private System.Windows.Forms.Button BTNNovell;
        private System.Windows.Forms.Button BTNRoman;
        private System.Windows.Forms.Button BTNTidskrift;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.Label ChosenGenreLable;
        private System.Windows.Forms.Button BTNAddBook;
    }
}