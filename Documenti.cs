using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Documenti
    {
        public int codice;
        public string titolo;
        int rilasciatoInData;
        string autore;
        public bool disponibilità;
        int posizioneScaffale;
        string settore;

        public Documenti(int codice, string titolo, int rilasciatoInData, string settore,bool disponibilità, int posizioneScaffale, string autore)
        {
            this.codice = codice;
            this.titolo = titolo;
            this.rilasciatoInData = rilasciatoInData;
            this.disponibilità = disponibilità;
            this.settore = settore;
            this.posizioneScaffale = posizioneScaffale;
            this.autore = autore;
        }

        public Documenti (int codice)
        {
            this.codice = codice;
        }
        public string LeggiInformazioni()
        {
            return $"Titolo: {titolo}\nAnno: {rilasciatoInData}\nGenere: {settore}\nPosizione: {posizioneScaffale}\ndisponibilità: {disponibilità}\nAutore: {autore}\n\n";
        }

    }
}
