using System;
using System.Collections.Generic;
using Kaczorek1.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kaczorek1.BLTest
{
    [TestClass]
    public class KlientRepositoryTest
    {
        [TestMethod]
        public void PobierzKlientaTest()
        {
            //Arrange
            var klientRepository = new KlientRepository();
            var oczekiwana = new Client(1)
            {
                Email = "marcin@hujek.pl",
                Imie = "Marcin",
                Nazwisko = "Kowal",
            };
            //Act

            var aktualna = klientRepository.Pobierz(1);

            //Assert

            Assert.AreEqual(oczekiwana.ClientId, aktualna.ClientId);
            Assert.AreEqual(oczekiwana.Email, aktualna.Email);
            Assert.AreEqual(oczekiwana.Imie, aktualna.Imie);
            Assert.AreEqual(oczekiwana.Nazwisko, aktualna.Nazwisko);
        }

        [TestMethod]
        public void PobierzKlientaZAdresami()
        {
            //Arrange
            var klientrepository = new KlientRepository();
            var oczekiwana = new Client(1)
            {
                Email = "marcin@hujek.pl",
                Imie = "Marcin",
                Nazwisko = "Kowal",
                ListaAdresow = new List<Adres>()
                {
                    new Adres()
                    {
                     AdresTyp = 1,
                     Street = "Adama",
                     Miasto = "Opole",
                     Kraj = "Polska",
                     KodPocztowy = "11-100"
                    },
                    new Adres()
                    {
                     AdresTyp = 3,
                     Street = "Miła",
                     Miasto ="Katowice",
                     Kraj = "Polska",
                     KodPocztowy = "44-400"
                    }
                }
            };


            //Act

            var aktualna = klientrepository.Pobierz(1);

            //Assert

            Assert.AreEqual(oczekiwana.ClientId, aktualna.ClientId);
            Assert.AreEqual(oczekiwana.Email, aktualna.Email);
            Assert.AreEqual(oczekiwana.Imie, aktualna.Imie);
            Assert.AreEqual(oczekiwana.Nazwisko, aktualna.Nazwisko);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(oczekiwana.ListaAdresow[i].AdresTyp, aktualna.ListaAdresow[i].AdresTyp);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].Street, aktualna.ListaAdresow[i].Street);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].Miasto, aktualna.ListaAdresow[i].Miasto);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].Kraj, aktualna.ListaAdresow[i].Kraj);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].KodPocztowy, aktualna.ListaAdresow[i].KodPocztowy);

            }
        }
    }
}
