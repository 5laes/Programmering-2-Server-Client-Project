using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avdelningsrapport
{
    class BookRoman : Book
    {
        public BookRoman(string newTitel, string newWriter, string newGenre, bool newTip)
        {
            Titel = newTitel;
            Writer = newWriter;
            Genre = newGenre;
            TipAvailable = newTip;
        }

        public override string ToString()
        {
            if (TipAvailable)
            {
                return $"{Titel} {Writer} {Genre}. Denna bok är tillgänglig";
            }
            return $"{Titel} {Writer} {Genre}. Denna bok finns inte för tillfället";
        }
    }
}
