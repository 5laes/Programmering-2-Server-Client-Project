using System.IO;

namespace Avdelningsrapport
{
    class FileWriter
    {
        // metod för att skriva in text i txt fil
        public void BookReader(string newBook)
        {
            if (File.Exists("texter.txt"))
            {
                using (StreamWriter SW = new StreamWriter("texter.txt", true))
                {
                    SW.WriteLine(newBook);
                }
            }
        }
    }
}
