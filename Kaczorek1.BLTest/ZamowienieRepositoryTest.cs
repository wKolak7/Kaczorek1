using System;
using Kaczorek1.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kaczorek1.BLTest
{
    [TestClass]
    public class ZamowienieRepositoryTest
    {
        [TestMethod]
        public void PobierzZamowienieTest()
        {
            //Arrange

            var zamowienierepository = new ZamowienieRepository();
            var oczekiwana = new Zamowienie(10)
            {
                DataZamowienia = new DateTimeOffset(2018, 4, 20, 11, 00, 00, new TimeSpan(7, 0, 0))
        };

            //Act

            var aktualna = zamowienierepository.Pobierz(10);

            //Assert

            Assert.AreEqual(oczekiwana.ZamowienieId, aktualna.ZamowienieId);
            Assert.AreEqual(oczekiwana.DataZamowienia, aktualna.DataZamowienia);
           
        }

        [TestMethod]
        public void PobierzZamowienieDoWyswietleniaTest()
        {
            //arrange
            var zamowienieRepository = new ZamowienieRepository();
            var oczekiwana = new WyswietlanieZamowienia()
            {


            }
        }
    }
}
