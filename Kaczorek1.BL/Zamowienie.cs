using System;
using System.Collections.Generic;

namespace Kaczorek1.BL
{
    public class Zamowienie
    {

        #region konstruktory
        public Zamowienie()
        {

        }
        public Zamowienie(int zamowienieId)
        {
            ZamowienieId = zamowienieId;

        }

        #endregion

        #region własciwości
        public int ZamowienieId { get; private set; }
        public DateTimeOffset? DataZamowienia { get; set; }



        public List<PozycjaZamowienia> pozycjaZamowienia { get; set; }
        public int KlientId { get; set; }
        public int AdresDostawyId { get; set; }
        #endregion


        #region metody
        //metody

        //sprawdza dane zamowienia
        public bool Validate()
        {
            var correct = true;

            if (DataZamowienia == null)
                correct = false;

            return correct;
        }

        public bool Zapisz()
        {
            return true;
        }

        public Zamowienie Pobierz(int zamowienieId)
        {
            // pobieramy jedno zamowienie
            return new Zamowienie();
        }

        //pobieramy wszystkie produkty
        public List<Zamowienie> Pobierz()
        {
            //kod ktory pobiera wszystkich klientow
            return new List<Zamowienie>();
        }
        #endregion 



    }
}
