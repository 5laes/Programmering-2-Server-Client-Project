using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
