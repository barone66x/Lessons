using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Movimento
    {


        public DateTime Ora { get; set; }
        public string Operazione { get; set; }
        public string Banca { get; set; }
        public string IdCliente { get; set; }
        public string Iban { get; set; }
        public double Ammontare { get; set; }
        public Movimento()
        {

        }


    }
}
