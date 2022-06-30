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


        public void stampaInfoUtente()
        {
            Console.WriteLine("Nome:" + this.nome);
            Console.WriteLine("cognome:" + this.cognome);
            Console.WriteLine("email:" + this.email);
            Console.WriteLine("Nome:" + this.recapitoTelefonico);


        }

        public string CercaTitolo()
        {
            Console.Write("Cerca per titolo: ");
            string titoloCercato = Console.ReadLine();

            return titoloCercato;
        }

        public int CercaPerCodice()
        {
            Console.Write("Cerca per codice: ");
            int codiceCercato = Int32.Parse(Console.ReadLine());

            return codiceCercato;
        }

        public Prestito EffettuaPrestito(Documenti doc, Utente utente, DateTime dal, DateTime al)
        {
            if (doc.disponibilità)
            {

                Prestito prestito = new Prestito();

                return prestito;
            }
            return null;

        }

        public void EffettuaPrestito(DateTime inizio, DateTime fine)
        {

        }
    }
}
