using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Verlag
{
    public class Buch
    {
        private string autor;
        private string titel;
        private int auflage;

        public Buch(string autor, string titel)
        {
            if (autor == "" || autor == "#" || autor == ";" || autor == "§" || autor == "%" || autor == null)
            {
                throw new ArgumentException("Name des Authors ist unzulässig");
            }
            else
            {
                this.autor = autor;
            }
            this.titel = titel;
            this.auflage = 1;
        }
            
        public Buch(string autor, string titel, int auflage) :this(autor, titel)
        {
            this.auflage = auflage;
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public string Titel
        {
            get { return titel; }
        }

        public int Auflage
        {
            get { return auflage; }
            set 
            {
                if (value > 0)
                {
                    auflage = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }



    }
}
