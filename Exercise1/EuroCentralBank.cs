using CountryExercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class EuroCentralBank
    {
        public static void ApplySpred(EuroZoneCountry country)
        {
            double value = country.Spred;
            value += 10;
            Console.WriteLine($"SPRED of {country.Name}   is: {value}");
        }

        //public static void ApplySpred(CountryDeathPunishment country)

        //{
        //    Console.WriteLine($"{country.Name} doesn't have EURO coin and I can't calculate spred");
        //}

        public static void ApplySpred(Country country)

        {
            Console.WriteLine($"{country.Name} doesn't have EURO coin and I can't calculate spred");
        }
    }
}
