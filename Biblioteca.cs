using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Biblioteca
    {
        public List<Prestito> listaPrestiti;
        public List<Documenti> listaDocumenti;
        public List<Prestito> ricercaPrestito(string name, string surname)
        {
            List<Prestito> prestitiCercati = new List<Prestito>();
            foreach (Prestito prestito in listaPrestiti)
            {
              
            }
            return prestitiCercati;
        }
    }
}
