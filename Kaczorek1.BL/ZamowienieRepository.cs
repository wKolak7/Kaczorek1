using System;
using System.Collections.Generic;

namespace Kaczorek1.BL
{
    public class ZamowienieRepository
    {



        public Zamowienie Pobierz(int zamowienieId)
        {
            Zamowienie zamowienie = new Zamowienie(zamowienieId);

            // pobieramy jedno zamowienie


            //tymczasowo zakodowane wartosci zamowienia

            if (zamowienieId == 10)
            {
                zamowienie.DataZamowienia = new DateTimeOffset(2018, 4, 20, 11, 00, 00, new TimeSpan(7, 0, 0));

            }

            return zamowienie;
        }

        //pobieramy wszystkie produkty
        public List<Zamowienie> Pobierz()
        {
            //kod ktory pobiera wszystkich klientow
            return new List<Zamowienie>();
        }
        public bool Zapisz()
        {
            return true;
        }

        /// <summary>
        /// Pobieramy jedno zamowienie do wyswieletnia
        /// </summary>
        /// <param name="zamowienieId"></param>
        /// <returns></returns>
        public WyswietlanieZamowienia PobierzZamowienieDoWyswietlenia(int zamowienieId)
        {
            WyswietlanieZamowienia wyswietlanieZamowienia = new WyswietlanieZamowienia();

            // kod ktory pobiera zdefinowane pola zamowienia

            //Tymczasowe  dane zakodowane na stałe
            if (zamowienieId == 10)
            {
                wyswietlanieZamowienia.Imie = "Jacek";
                wyswietlanieZamowienia.Nazwisko = "Kowal";
                wyswietlanieZamowienia.DataZamowienia = new DateTimeOffset(2018, 5, 21, 12, 00, 00, new TimeSpan(5));
                wyswietlanieZamowienia.AdresDostawy = new Adres()
                {
                    AdresTyp = 2,
                    Street = "Miła",
                    Miasto = "Katowice",
                    Kraj = "Polska",
                    KodPocztowy = "44-400"
                };

                wyswietlanieZamowienia.WyswietlaniePozycjiZamowieniaLista = new List<WyswietlaniePozycjiZamowienia>();

                //kod ktory pobiera elementy zamowienia

                //tymczasowe dane zakodowane na stale
                if (zamowienieId == 10)
                {
                    var wyswietlaniePozycjiZamowienia = new WyswietlaniePozycjiZamowienia()
                    {
                        NazwaProduktu = "Stol",
                        CenaZakupu = 300.50M,
                        Ilosc = 10
                    };
                    wyswietlanieZamowienia.WyswietlaniePozycjiZamowieniaLista.Add(wyswietlaniePozycjiZamowienia);

                    wyswietlaniePozycjiZamowienia = new WyswietlaniePozycjiZamowienia()
                    {
                        NazwaProduktu = "Blat",
                        CenaZakupu = 50.33M,
                        Ilosc = 5
                    };
                    wyswietlanieZamowienia.WyswietlaniePozycjiZamowieniaLista.Add(wyswietlaniePozycjiZamowienia);


                }

                return wyswietlanieZamowienia;
            }

        }


    }
}
