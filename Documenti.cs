using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Documenti
    {
        protected int codice;
        protected string titolo;
        protected int rilasciatoInData;
        protected string autore;
        protected bool disponibilità;
        protected int posizioneScaffale;
        protected string settore;

        public Documenti(int codice, string titolo, int rilasciatoInData, string settore, bool disponibilità, int posizioneScaffale, string autore)
        {
            this.codice = codice;
            this.titolo = titolo;
            this.rilasciatoInData = rilasciatoInData;
            this.settore = settore;
            this.disponibilità = disponibilità;
            this.posizioneScaffale = posizioneScaffale;
            this.autore = autore;
        }
    }
}
