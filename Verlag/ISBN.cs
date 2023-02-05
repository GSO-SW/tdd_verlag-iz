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
    }
}
