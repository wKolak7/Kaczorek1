using System;
using Kaczorek1.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kaczorek1.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void PobierzRepositoryTest()
        {
            //Arrange

            var produktrepository = new ProductRepository();
            var oczekiwana = new Produkt(5)
            {
                NazwaProduktu = "Klocki",
                Opis = "Klocki dla dzieci",
                AktualnaCena = 89.99M
            };

            //Act

            var aktualna = produktrepository.Pobierz(5);

            //Assert

            Assert.AreEqual(oczekiwana.ProduktId , aktualna.ProduktId);
            Assert.AreEqual(oczekiwana.NazwaProduktu, aktualna.NazwaProduktu);
            Assert.AreEqual(oczekiwana.Opis, aktualna.Opis);
            Assert.AreEqual(oczekiwana.AktualnaCena, aktualna.AktualnaCena);

        }
    }
}
