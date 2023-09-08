using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer
{
    internal static class Menu
    {

        public static void Choice()
        {
            Console.WriteLine("- - - - - - - - - - - - - - ");
            Console.WriteLine("Press m for Movie or s");
            Console.WriteLine("- - - - - - - - - - - - - - ");
            Console.WriteLine();
            Console.WriteLine();


        }

        public static void ShowMenu()
        {
            Console.WriteLine("- - - - - - - - - - - - - - ");
            Console.WriteLine("Next Press: f");
            Console.WriteLine("Previous Press: b");
            Console.WriteLine("Pause: p");
            Console.WriteLine("- - - - - - - - - - - - - - ");
            Console.WriteLine("Exit: e");
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void ChoseNumber()
        {
            Console.WriteLine("- - - - - - - - - - - - - - ");
            Console.WriteLine("Chose a number to enter in the section");
            Console.WriteLine("- - - - - - - - - - - - - - ");
            Console.WriteLine();
            Console.WriteLine();
        }

    }
}
