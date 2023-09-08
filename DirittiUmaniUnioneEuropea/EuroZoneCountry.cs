using Polimorfismo.Interfaces;
using System;

namespace Polimorfismo
{

    public class EuroZoneCountry : EUCountry, IEuroZone
    {
        // ONU Contracts
        // EURO Contracts
        // EU Contracts 
        internal protected static int TotalPopulation { get; set; }

        public EuroZoneCountry(string Name, string State, string Government, string Constitution, int population)
            : base(Name, State, Government, Constitution, population)
        {
            TotalPopulation += population;
        }


        public void Euro()
        {
            //Contratto EURO ZONA 
        }

        public static void ShowTotalPopulation()
        {
            Console.WriteLine($"Total Population of EuroZone Country is: {TotalPopulation}");
        }
    }



}

