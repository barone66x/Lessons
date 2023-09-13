using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class Banca
    {


        public string Nomebanca;
        public string Stato;
        public Monete Moneta;
        public string PartitaIva;
        public double Capitale;

        public Banca(string nomebanca, string stato, Monete moneta, string partitaiva, double capitale)
        {
            Nomebanca = nomebanca;
            Stato = stato;
            Moneta = moneta;
            PartitaIva = partitaiva;
            Capitale = capitale;

        }


        public abstract void Prestiti();

    }
}
