using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Persona
    {
        //private string Nome;
        //private string Cognome;      
        //private DateTime DataNascita;
        //private string CodiceFiscale;
        public string Nome { get; }
        public string Cognome { get; }
        public DateTime DataNascita { get; }
        public string CodiceFiscale { get; }

        public Persona(string nome, string cognome, DateTime data, string codiceFiscale)
        {

            Nome = nome;
            Cognome = cognome;
            DataNascita = data;
            CodiceFiscale = codiceFiscale;
        }


    }
}
