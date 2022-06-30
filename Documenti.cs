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
        public string titolo;
        protected int rilasciatoInData;
        protected string autore;
        protected bool disponibilità;
        protected int posizioneScaffale;
        protected string settore;

        public Documenti(int codice, string titolo, int rilasciatoInData, string settore, int posizioneScaffale, string autore)
        {
            this.codice = codice;
            this.titolo = titolo;
            this.rilasciatoInData = rilasciatoInData;
            this.settore = settore;
            this.posizioneScaffale = posizioneScaffale;
            this.autore = autore;
        }
        public string LeggiInformazioni()
        {
            return $"Titolo: {titolo}\nAnno: {rilasciatoInData}\nGenere: {settore}\nPosizione: {posizioneScaffale}\\nAutore: {autore}\n\n";
        }

    }
}
