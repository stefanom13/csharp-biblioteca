using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Biblioteca
    {
        protected string nome;
        public Biblioteca(string nome)
        {
            this.nome = nome;
        }
        public void Riproduci()
        {
            Console.WriteLine("Nome:" + this.nome);
        }
    }
}