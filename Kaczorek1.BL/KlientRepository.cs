using System.Collections.Generic;
using System.Linq;
namespace Kaczorek1.BL
{
    public class KlientRepository
    {

        private AdresRepository adresRepository { get; set; }

        public KlientRepository()
        {
            adresRepository = new AdresRepository();
        }
     
        public Client Pobierz(int clientId)
        {
            //tworzymy instancje klasy klienta 
            Client client = new Client(clientId);
            client.ListaAdresow = adresRepository.PobierzPoKlientId(clientId).ToList();

            //kod ktory pobiera okreslonego klienta

            //Zwracanie klienta tymczasowe
            if (clientId == 1 )
            {
                client.Email = "marcin@hujek.pl";
                client.Imie = "Marcin";
                client.Nazwisko = "Kowal";
               
            }

            return client;
        }
    
        public List<Client> Pobierz()
        {
           
            return new List<Client>();
        }

        public bool Zapisz()
        {
            return true;
        }
    }
}
