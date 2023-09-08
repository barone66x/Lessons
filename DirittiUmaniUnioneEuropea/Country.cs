using System;
using DirittiUmaniUnioneEuropea;

namespace Polimorfismo
{
    public abstract class Country : GeographicArea
    {
        private string name;
        private string _state;
        private string _government;
        private string _constitution;
        private int _population;

        public string Name { get => name; set => name = value; }
        public string State { get => _state; set => _state = value; }
        public string Government { get => _government; set => _government = value; }
        public string Constitution { get => _constitution; set => _constitution = value; }
        public int Population { get => _population; set => _population = value; }



        public Country()
        {

        }
        public Country(string Name, string State, string Government, string Constitution, int population)
        {
            name = Name;
            _state = State;
            _government = Government;
            _constitution = Constitution;
            _population = population;
            ShowState();
        }
        void ShowState()
        {
            Console.WriteLine($"{Name} -  {Constitution}");
        }

    }
}
