using System;
using System.Collections.Generic;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test();

            // Console.WriteLine();




            BancaCommerciale intesa = new BancaCommerciale("Intesa_San_Paolo", "Italia", Monete.EUR, "ABCDE001", 500000, "INTS01");
            BancaCommerciale unicredit = new BancaCommerciale("Unicredit", "Italia", Monete.EUR, "ASDASD02", 900000, "UNIC02");
            //  Cliente p1 = new Cliente("Mattia", "banana", "lgrmtt");
            List<Persona> persone = new List<Persona>();
            List<BancaCommerciale> banche = new List<BancaCommerciale>();
            banche.Add(intesa);
            banche.Add(unicredit);

            persone.Add(new Persona("Mattia", "Li Greci", new(2004, 09, 13), "lgrmtt04a16c523f"));
            persone.Add(new Persona("Davide", "Mattavelli", new(2006, 07, 22), "asdasfseref34df"));
            persone.Add(new Persona("Marco", "Polo", new(2001, 01, 22), "kljoij435lkj"));

            Utility.caricaBanche(banche);
            Persona io = Utility.ChiSei(persone);
            BancaCommerciale miaBanca = Utility.CheBanca(banche);
            miaBanca.Accesso(io);


        }




        private static void Test()
        {
            string path = @"C:\Users\mattia.ligreci\Documents\Test\movimenti.csv";
            List<string> lines = FileLoader.ReadfromFile(path);
            List<Movimento> list = FileLoader.CreateObject<Movimento>(lines);
            string path2 = @"C:\Users\mattia.ligreci\Documents\Test\Clienti_Intesa.csv";


            var lines2 = FileLoader.ReadfromFile(path2);
            List<Cliente> clienti = FileLoader.CreateObject<Cliente>(lines2);

        }
    }
}
