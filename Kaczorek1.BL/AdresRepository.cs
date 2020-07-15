using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaczorek1.BL
{
    public class AdresRepository
    {
        /// <summary>
        /// Pobieramy jeden adres
        /// </summary>
        /// <param name="adresid"></param>
        /// <returns></returns>
        public Adres Pobierz(int adresid)
        {
            /// Tworzymy instancje klasy adres i przekazujemy  żądany identyfikator
            
            // Kod , który pobiera zdefiniowany adres

            //Tymczasowo zakodowane wartości do zwrócenia adresu
            Adres adres = new Adres(adresid);
            if (adresid == 1)
            {
                adres.AdresTyp = 1;
                adres.Street = "Gościnna";
                adres.Miasto = "Katowice";
                adres.Kraj = "Polska";
                adres.KodPocztowy = "40-467";
                    
            }

            return adres;

        }


        /// <summary>
        /// Pobieramy wszystkie zdefiniowane adresy dla klienta o przekazanym klientId
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public IEnumerable<Adres> PobierzPoKlientId(int clientId)
        {
            // Kod , który pobiera zdefiniowane adresy dla klienta

            // Tymczasowo zakodowane wartości do zwrócenia , zestaw adresów
            var listaAdresow = new List<Adres>();

            Adres adres = new Adres(1)
            {
                AdresTyp = 1,
                Street = "Adama",
                Miasto = "Opole",
                Kraj = "Polska",
                KodPocztowy = "11-100"

            };
            listaAdresow.Add(adres);


           adres = new Adres(2)
            {
                AdresTyp = 3,
                Street = "Miła",
                Miasto ="Katowice",
                Kraj = "Polska",
                KodPocztowy = "44-400"

            };
            listaAdresow.Add(adres);

            return listaAdresow;
        }


        ///<summary>
        ///  Zapisuje aktualny adres
        /// </summary>
        public bool Zapisz(Adres adres)
        {
            // kod który zapisuje zdefiniowany adres.

            return true;
        }

    }
}
