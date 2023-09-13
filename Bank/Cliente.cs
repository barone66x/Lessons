using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Cliente
    {
        //private string Username;
        //private string Password;
        //private string codiceFiscale;
        //private Guid id;
        //List<string> ibans;

        public string Username { get; set; }
        public string Password { get; set; }
        public string CodiceFiscale { get; set; }
        public string IdCliente { get; set; }
        // public List<string> Ibans { get; set; }

        public Cliente(Persona persona, string username, string password)
        {
            Username = username;
            Password = password;
            CodiceFiscale = persona.CodiceFiscale;
            IdCliente = Guid.NewGuid().ToString();
            //Ibans = new List<string>();
        }
        public Cliente()
        {

        }
    }
}
