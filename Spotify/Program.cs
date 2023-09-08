using System;
using System.IO;
using System.Reflection.PortableExecutable;

namespace Spotify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string path = @"C:\Users\mattia.ligreci\Documents\Test\databaCanzoni.txt";
            using (StreamReader sr = new StreamReader(path))
            {


                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    var values = line.Split(',');

                }
            }
        }
    }
}
