using System;
using Kaczorek1.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kaczorek1.BLTest
{
    [TestClass]
    public class ClientTest
    {
        [TestMethod]
        public void ImieNazwiskoTest()
        {
            //Arrange 
            Client client = new Client();
            client.Imie = "Wojciech";
            client.Nazwisko = "Korzeniowski";

            string expected = "Wojciech,Korzeniowski";

            //Act 
            string actual = client.ImieNazwisko;
            //Assert 
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ImieNazwiskoPusteTest()
        {
            //Arrange 
            Client client = new Client();
            client.Imie = "Robert";


            string expected = "Robert";

            //Act 
            string actual = client.ImieNazwisko;
            //Assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //Arrange 
            var client1 = new Client();
            client1.Imie = "Jacek";
            Client.Counter += 1;

            var client2 = new Client();
            client2.Imie = "Maciek";
            Client.Counter += 1;

            var client3 = new Client();
            client3.Imie = "Irek";
            Client.Counter += 1;


            //Act 

            //Assert 

            Assert.AreEqual(3, Client.Counter);

        }


        [TestMethod]
        public void ValidateTest()
        {
            //Arrange
            var client = new Client();
            client.Nazwisko = "Kowal";
            client.Email = "marcin@dey-hobby.pl";

            var expected = true;
            //Act
            var actual = client.Validate();


            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void ValidateNoSecondNameTest()
        {
            //Arrange
            var client = new Client();
            client.Nazwisko = "Kowal";
            client.Email = "marcin@dey-hobby.pl";

            var expected = true;
            //Act
            var actual = client.Validate();


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateEmailTest()
        {
            //Arrange
            var client = new Client();
            client.Nazwisko = "Kowal";


            var expected = false;
            //Act
            var actual = client.Validate();


            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
