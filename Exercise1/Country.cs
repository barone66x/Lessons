using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryExercise
{
    internal abstract class Country : IONU
    {
        public int Population { get; set; }
        public string Government { get; set; }
        public string Coin { get; set; }
        public string Name { get; set; }

        public void PopulationControl()
        {

        }

        public void TerritoriesControl()
        {

        }
    }
}
