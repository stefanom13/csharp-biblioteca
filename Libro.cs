using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Libro :  Documenti
    {
        protected int nPagine { get; set; } 
        public int ISBN;

        public Libro(int codice, int ISBN, string titolo, int rilasciatoInData, string settore, bool disponibilità, int posizioneScaffale, string autore, int nPagine) : base(codice, titolo, rilasciatoInData, settore, posizioneScaffale, autore)
        {
            this.nPagine = nPagine;
            this.ISBN = ISBN;
        }

      
        private string GenerateISBN()
        {
            string isbnGenerato = "";
            for (int codice = 0; codice < 13; codice++)
            {
                codice += new Random().Next(10);
            }
            return isbnGenerato;
        }
    }
}
