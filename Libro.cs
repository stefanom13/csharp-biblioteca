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
        public string ISBN;

        public Libro(int codice, string ISBN, string titolo, int rilasciatoInData, string settore, bool disponibilità, int posizioneScaffale, string autore, int nPagine) : base(codice, titolo, rilasciatoInData, settore, disponibilità, posizioneScaffale, autore)
        {
            this.nPagine = nPagine;
            this.ISBN = ISBN;
        }
    }
}
