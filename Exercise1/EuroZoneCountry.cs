using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryExercise
{
    internal class EuroZoneCountry : EUZone, IEuroZone
    {
        public double Spred { get; set; }
        public double Debt { get; set; }

        public EuroZoneCountry()
        {
            ApplyEuro();
        }

        public void ApplyEuro()
        {
            Coin = "EURO";
        }



    }
}
