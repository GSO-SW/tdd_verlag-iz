using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verlag
{
    public class Buch
    {
        private string autor;
        private string titel;
        private int auflage;

        public Buch(string autor, string titel) 
        {
            if (autor != null && autor != "" && autor != "#" && autor != ";" && autor != "§" && autor != "%")
            {
                this.autor = autor;
            }
            else
                throw new ArgumentException();

            this.titel = titel;
            this.auflage = 1;
        }

        public Buch(string autor, string titel,int auflage) : this(autor,titel)
        {
            this.auflage = auflage;
        }



        public string Autor
        {
            get { return autor; }

            set 
            {
                
                    autor = value;
               
            }
        }

        public string Titel
        {
            get { return titel; }
        }

        public int Auflage
        {
            get { return auflage; }
            set { auflage = value; }
        }
    }
}
