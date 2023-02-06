using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verlag
{
    public class ISBN
    {
        private string isbn;

        public ISBN(string isbn)
        {
            this.isbn = isbn;
        }   

        public string ISbn
        {
            set
            {
                isbn = value;
            }
            get { return isbn; }
        }


        public string ISBNPruffZifferEingabe(string isbnOhnePruffziffer)
        {
            string isbnmitpruffziffer;
            int multiplikationspeichern;
            int ergebniss = 0;
            for (int i = 1; i <= 9; i++)
            {
                multiplikationspeichern = Convert.ToInt32(isbnOhnePruffziffer[i - 1]) * i;
                ergebniss += multiplikationspeichern;
            }

            ergebniss = ergebniss % isbnOhnePruffziffer.Length;

            isbnmitpruffziffer = isbnOhnePruffziffer.Insert(isbnOhnePruffziffer.Length, Convert.ToString(ergebniss));
            return isbnmitpruffziffer;
        }

        public string ISBN10(string isbn)
        {
            string ISBN = "9783770436163";
            ISBN = ISBN.Remove(0, 3);
            ISBN = ISBN.Remove(ISBN.Length - 1, 1);

            int einzelneZahl;
            int zwischenspeicher;
            string neueISBN = "";
            int multiplikationsFaktor = 10;

            for (int i = 0; i > ISBN.Length; i++)
            {
                einzelneZahl = ISBN[i];

                zwischenspeicher = einzelneZahl * multiplikationsFaktor;

                neueISBN = neueISBN + zwischenspeicher;

                multiplikationsFaktor--;
            }

            return neueISBN;
        }

    }
}
