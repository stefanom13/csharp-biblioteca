using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Prestito 
    {
        
        public Documenti doc;
        public Utente utente;



        public Prestito(Documenti doc, Utente utente)
        {
            this.doc = doc;
            this.utente = utente;
        }
    }
}
