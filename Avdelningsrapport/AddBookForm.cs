using System;
using System.Windows.Forms;

namespace Avdelningsrapport
{
    public partial class AddBookForm : Form
    {
        string genre = "";
        //objekt som gör att vi kan lägga till nya böcker
        FileWriter addedBook = new FileWriter();
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void BTNNovell_Click(object sender, EventArgs e)
        {
            genre = "Novellsamling";
            GenreTextBox.Text = "Novellsamling";
        }

        private void BTNRoman_Click(object sender, EventArgs e)
        {
            genre = "Roman";
            GenreTextBox.Text = "Roman";
        }

        private void BTNTidskrift_Click(object sender, EventArgs e)
        {
            genre = "Tidskrift";
            GenreTextBox.Text = "Tidskrift";
        }

        /*Har fortfarande inte gjort att listan uppdateras när man lägger till en bok
         lyckas inte hitta någon bra och smidig lösning*/
        private void BTNAddBook_Click(object sender, EventArgs e)
        {
            if (TitleTextBox.Text.Trim() == "" || WriterTextBox.Text.Trim() == "" || GenreTextBox.Text == "")
            {
                AddBookError error = new AddBookError();
                error.Show();
                return;
            }

            string newTitle = TitleTextBox.Text.Trim();
            string newWriter = WriterTextBox.Text.Trim();
            string book = $"{newTitle}###{newWriter}###{genre}###true";
            addedBook.BookReader(book);
            this.Close();
        }
    }
}
