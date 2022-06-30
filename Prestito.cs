using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Prestito 
    {
        public DateTime dal;
        public DateTime al;
        public Documenti doc;

        public Prestito(DateTime dal, DateTime al, Documenti doc)
        {
            this.dal = dal;
            this.al = al;
            this.doc = doc;
        }
        //public void stampaInfoUtente()
       // {
          
       // }
    }
}
