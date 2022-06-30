using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Utente
    {
        private string nome;
        private string cognome;
        private string email;
        private string password;
        private int recapitoTelefonico;
        public bool eLoggato = false;


        public Utente(string nome, string cognome, string email, string password, int recapitoTelefonico, bool eLoggato)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.email = email;
            this.password = password;
            this.recapitoTelefonico = recapitoTelefonico;
            this.eLoggato = true;
        }

        public void EffettuaPrestito(DateTime inizio, DateTime fine)
        {
           
        }



        public void stampaInfoUtente()
        {
            Console.WriteLine("Nome:" + this.nome);
            Console.WriteLine("cognome:" + this.cognome);
            Console.WriteLine("email:" + this.email);
            Console.WriteLine("password:" + this.password);
            Console.WriteLine("Nome:" + this.recapitoTelefonico);
            
         
        }
        public Documenti CercaTitolo(string titolo, Biblioteca biblioteca)
        {
            Documenti documentoDaPassare = null;
            foreach (Documenti doc in biblioteca.listaDocumenti)
            {
                if (titolo == doc.titolo)
                {
                    documentoDaPassare = doc;
                }
            }
            return documentoDaPassare;
        }

}
