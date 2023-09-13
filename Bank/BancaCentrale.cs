using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class BancaCentrale : Banca
    {
        public BancaCentrale(string nomebanca, string stato, Monete moneta, string partitaiva, double capitale) : base(nomebanca, stato, moneta, partitaiva, capitale)
        {
            Nomebanca = nomebanca;
            Stato = stato;
            Moneta = moneta;
            PartitaIva = partitaiva;
            Capitale = capitale;

        }
        public void StampaDenaro() { }

        public override void Prestiti() { }
    }
}
