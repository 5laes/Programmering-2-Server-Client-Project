namespace Avdelningsrapport
{
    class BookTidskrift : Book 
    {
        public BookTidskrift(string newTitel, string newWriter, string newGenre, bool newTip)
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
