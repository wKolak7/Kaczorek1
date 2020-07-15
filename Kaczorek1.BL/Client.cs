using System.Collections.Generic;

namespace Kaczorek1.BL
{
    public class Client
    {
        #region konstruktory
        public Client() : this(0)
        {
            
        }
        public Client(int clientId)
        {
            ClientId = clientId;
            ListaAdresow = new List<Adres>();
        }
        #endregion


        #region właściwości
        //wlasciwosci
        public static int Counter { get; set; }

        private string _nazwisko;

        public string Nazwisko
        {
            get { return _nazwisko; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _nazwisko = value;
            }
        }

        public string Imie { get; set; }
        public string Email { get; set; }
        public int ClientId { get; private set; }

        public string ImieNazwisko
        {
            get
            {
                string imieNazwisko = Imie;

                if (!string.IsNullOrWhiteSpace(Nazwisko))
                {
                    imieNazwisko += ",";
                    imieNazwisko += Nazwisko;
                }
                return imieNazwisko;
            }

        }

        public List<Adres> ListaAdresow { get; set; }
       
        #endregion


        #region metody

        //sprawdza dane produktu
        public bool Validate()
        {
            var correct = true;

            if (string.IsNullOrWhiteSpace(Nazwisko))
                correct = false;

            if (string.IsNullOrWhiteSpace(Email))
                correct = false;

            return correct;
        }

        public bool Zapisz()
        {
            return true;
        }
        public Client Pobierz(int clientId)
        {
            //kod ktory pobiera okreslony produkt
            return new Client();
        }
        //pobieramy wszystkie produkty
        public List<Client> Pobierz()
        {
            //kod ktory pobiera wszystkich klientow
            return new List<Client>();
        }
        #endregion
    }
}



