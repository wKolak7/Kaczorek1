using System;
using System.Collections.Generic;

namespace Kaczorek1.BL
{
    public class Produkt
    {
        public Produkt()
        {

        }
        public Produkt(int produktId)
        {
            ProduktId = produktId;
        }

        public int ProduktId { get; private set; }
        public Decimal? AktualnaCena { get; set; }
        public string Opis { get; set; }
        public string NazwaProduktu { get; set; }


        //metody

        //sprawdza dane produktu
        public bool Validate()
        {
            var correct = true;

            if (string.IsNullOrWhiteSpace(NazwaProduktu))
                correct = false;

            if (AktualnaCena == null)
                correct = false;

            return correct;
        }

        public bool Zapisz()
        {
            return true;
        }
        public Produkt Pobierz(int produktId)
        {
            //kod ktory pobiera okreslony produkt
            return new Produkt();
        }
        //pobieramy wszystkie produkty
        public List<Produkt> Pobierz()
        {
            //kod ktory pobiera wszystkich klientow
            return new List<Produkt>();
        }

    }
}
