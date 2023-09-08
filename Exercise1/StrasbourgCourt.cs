using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryExercise
{
    internal class StrasbourgCourt
    {
        public static void JudgeCountry(CountryDeathPunishment country)
        {
            Console.WriteLine($"{country.Name} apply Death Punishment");

        }

        public static void JudgeCountry(Country country)
        {
            Console.WriteLine($"{country.Name} doesn't apply Death Punishment");

        }

        public void Test() { }



        //public static void HumanRightsInvestigation(IONU ONUcountry) //UP-CASTING
        //{
        //    try
        //    {
        //        CountryDeathPunishment countryDeath = (CountryDeathPunishment)ONUcountry;
        //        Console.WriteLine($"{countryDeath.Name} apply Death Punishment");
        //    }
        //    catch ( InvalidCastException ex)
        //    {
        //        ONUcountry country 
        //    }

        //}
    }
}
