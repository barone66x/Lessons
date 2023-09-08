using CountryExercise;
using System;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EuroZoneCountry country = new EuroZoneCountry();
            country.Spred = 5;
            country.Name = "Italia";
            CountryDeathPunishment country2 = new CountryDeathPunishment();
            country2.Name = "IRAQ";
            CountryDeathPunishment country3 = new CountryDeathPunishment();
            country3.Name = "Rubilandd";




            EuroCentralBank.ApplySpred(country);
            StrasbourgCourt.JudgeCountry(country);


            EuroCentralBank.ApplySpred(country2);
            StrasbourgCourt.JudgeCountry(country2);

            EuroCentralBank.ApplySpred(country3);
            StrasbourgCourt.JudgeCountry(country3);

        }
    }
}
