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
        private string isbn;

        public Buch(string autor, string titel) 
        {
            if (autor.Contains("") || autor.Contains("#") || autor.Contains(";") || autor.Contains("§") || autor.Contains("%"))
            {
                throw new ArgumentException();
            }
            else
                this.autor = autor;
                this.titel = titel;
                this.auflage = 1;

        }

        public Buch(string autor, string titel,int auflage) : this(autor,titel)
        {
            if (auflage > 0)
            {
                this.auflage = auflage;
            }
            else throw new ArgumentOutOfRangeException();
            
        }

        public string ISBN
        {
            set
            {
                isbn = value;
            }
            get { return isbn; }
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
            set 
            {
                if (value > 0)
                {
                    
                    auflage = value;
                }
                else throw new ArgumentOutOfRangeException();

            }
        }
    }
}
