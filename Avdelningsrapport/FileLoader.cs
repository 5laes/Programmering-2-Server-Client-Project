using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avdelningsrapport
{
    class FileLoader
    {
        readonly List<string> textSaver = new List<string>();
        readonly List<string[]> vectorList = new List<string[]>();

        //Läser all text från en .txt fil och sparar det i en vektor lista
        public bool ReadFile()
        {
            if (File.Exists("texter.txt"))
            {
                using (StreamReader SR = new StreamReader("texter.txt", Encoding.Default))
                {
                    string text;
                    while ((text = SR.ReadLine()) != null)
                    {
                        textSaver.Add(text);
                    }
                }
            }
            else
            {
                return false;
            }

            foreach (string savedText in textSaver)
            {
                string[] vector = savedText.Split(new string[] { "###" }, StringSplitOptions.None);
                vectorList.Add(vector);
            }
            return true;
        }

        //Skapar ett bokobjekt med rätt genre
        private Book CreatBook(string[] book)
        {
            string titel = book[0];
            string Writer = book[1];
            string genre = book[2];
            Boolean.TryParse(book[3], out bool tipAvailable);

            switch (genre)
            {
                case "Roman":
                    return new BookRoman(titel, Writer, genre, tipAvailable);

                case "Novellsamling":
                    return new BookNovellsamling(titel, Writer, genre, tipAvailable);

                case "Tidskrift":
                    return new BookTidskrift(titel, Writer, genre, tipAvailable);

                default:
                    return null;
            }
        }

        //Skapar objekt som returneras till "ClientForm" så dom kan användas
        public List<Book> CreateBooks()
        {
            List<Book> books = new List<Book>();
            foreach (string[] item in vectorList)
            {
                Book book = CreatBook(item);
                books.Add(book);
            }
            return books;
        }
    }
}
