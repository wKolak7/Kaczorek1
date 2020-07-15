using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaczorek1.BL
{
    public class ProductRepository
    {
    
        public Produkt Pobierz(int produktId)
        {

            //tworzenie instancji produktu

            Produkt produkt = new Produkt(produktId);




            //kod ktory pobiera okreslony produkt


            // tymczasowo zwracane wartosci
            if (produktId== 5)
            {
                produkt.NazwaProduktu = "Klocki";
                produkt.Opis = "Klocki dla dzieci";
                produkt.AktualnaCena = 89.99M;

             }
                return produkt;

        }
        //pobieramy wszystkie produkty
        public List<Produkt> Pobierz()
        {
            //kod ktory pobiera wszystkich klientow
            return new List<Produkt>();
        }
        public bool Zapisz()
        {
            return true;
        }
    }
}
