using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Dvd : Documenti
    {
        protected int durata;
        public int numeroSeriale;

        public Dvd(int codice, int numeroSeriale, string titolo, int rilasciatoInData, string settore, bool disponibilità, int posizioneScaffale, string autore, int durata) : base(codice, titolo, rilasciatoInData, settore, posizioneScaffale, autore)
        {
            this.durata = durata;
            this.numeroSeriale = numeroSeriale;
        }
    }
}
