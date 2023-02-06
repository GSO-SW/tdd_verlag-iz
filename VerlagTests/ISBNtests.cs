using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Verlag;

namespace VerlagTests
{
    [TestClass]
    public class ISBNtests
    {

        [TestMethod]
        public void ISBN_DarfGesetztWerden()
        {
            //Arrange
            string ISBN = "9783770436163";

            //ACT
            ISBN i = new ISBN(ISBN);
            i.ISbn = ISBN;

            //Assert
            Assert.AreEqual(i.ISbn, ISBN);

        }

        [TestMethod]
        public void ISBNPruffZifferEingabe_AutomatischeErgaenzungVonPruffziffer()
        {
            //Arrang 
            string isbnohnepruffziffer = "978377043616";
            string isbnmitpruffziffer = "9783770436163";

            ISBN b = new ISBN(isbnmitpruffziffer);

            //Act
            string ergaenzteISBN = b.ISBNPruffZifferEingabe(isbnohnepruffziffer);
            //Assert
            Assert.AreEqual(ergaenzteISBN, isbnmitpruffziffer);
        }

        //Anleitung
        //https://www.quora.com/How-do-you-convert-a-13-digit-ISBN-to-a-10-digit-ISBN
        [TestMethod]
        public void ISBN13_konvertierenZuISBN10()
        {
            //Act
            ISBN i = new ISBN("9783770436163");

            //Assert
            Assert.AreEqual("3770436164", i.ISBN10("9783770436163"));
        }
    }
}
    