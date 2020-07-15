namespace Kaczorek1.BL
{
    public class PozycjaZamowienia
    {
        public PozycjaZamowienia()
        {

        }

        public PozycjaZamowienia(int pozycjaZamowieniaId)
        {
            PozycjaZamowieniaId = pozycjaZamowieniaId;
        }

        public int PozycjaZamowieniaId { get; private set; }
        public int Ilosc { get; set; }
        public int ProduktId { get; set; }
        public decimal? CenaZakupu { get; set; }

        //sprawdza dane pozycji zamowienia
        public bool Validate()
        {
            var correct = true;

            if (Ilosc <= 0)
                correct = false;
            if (ProduktId <= 0)
                correct = false;
            if (CenaZakupu <= 0)
                correct = false;

            return correct;
        }

        public bool Zapisz()
        {
            return true;
        }
        public PozycjaZamowienia Pobierz(int pozycjaZamowieniaId)
        {   
            return new PozycjaZamowienia();
        }
    }
}
