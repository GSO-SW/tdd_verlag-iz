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
    }
}
