using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public static class Utility
    {

        public static Persona ChiSei(List<Persona> persone)
        {
            Console.WriteLine("Chi sei? inserisci il numero");
            int i = 0;
            foreach (Persona persona in persone)
            {
                Console.WriteLine($"numero persona: {i}  dati: {persona.Nome} {persona.Cognome} " +
                    $"{persona.DataNascita.Day}-{persona.DataNascita.Month}-{persona.DataNascita.Year} " +
                    $"{persona.CodiceFiscale}");
                i += 1;
            }
            int input = int.Parse(Console.ReadLine());
            return persone[input];
        }
        public static BancaCommerciale CheBanca(List<BancaCommerciale> banche)
        {
            Console.WriteLine("inserisci il numero della banca in cui vuoi registrarti / loggarti");
            int i = 0;
            foreach (BancaCommerciale banca in banche)
            {
                Console.WriteLine($"numero banca: {i}  nome banca: {banca.Nomebanca} stato: {banca.Stato}");
                i += 1;
            }
            int input = int.Parse(Console.ReadLine());
            return banche[input];

        }

        public static void caricaBanche(List<BancaCommerciale> banche)
        {
            foreach (var banca in banche)
            {
                banca.CaricaMemoria();
            }
        }


    }
}
