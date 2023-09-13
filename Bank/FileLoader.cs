using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class FileLoader
    {
        public static List<string> ReadfromFile(string path)
        {
            var lines = File.ReadAllLines(path).ToList();
            return lines;
        }


        public static List<T> CreateObject<T>(List<string> lines) where T : class, new() //constrait
        { //dice che T deve essere una classe, e deve essere istanziabile
            List<T> list = new List<T>();
            string[] headers = lines.ElementAt(0).Split(',');
            lines.RemoveAt(0); // Rimuovo la prima riga (nome colonne) del mio datasource
            bool corretto = false;
            bool p = true;
            T entry = new T(); // Creo istanza per poter estrarre le properties
            PropertyInfo[] prop = entry //informazioni delle prop dell'oggetto di tipo T (nome, tipo ecc)
                            .GetType() // Prendo il tipo
                                    .GetProperties(); // Prendo le sue properties 

            if (true)
            {
                for (int i = 0; i < prop.Length; i++) // Ciclo le properties dell'oggetto  T
                {
                    if (prop.ElementAt(i).Name == headers[i]) // ciclo le colonne e le properties insieme
                    {
                        corretto = true;
                    }
                    else p = false; // S eha fallito almeno una volta, setto a false
                }
            }
            if (corretto && p)
            {
                foreach (var line in lines)
                {
                    int j = 0;
                    string[] columns = line.Split(','); //divido la linea in colonne (celle)
                    entry = new T(); // Per ogni riga del CSV creo un nuovo oggetto di tipo T
                    foreach (var col in columns) // cicle le colonne del CSV
                    {
                        entry.GetType()
                            .GetProperty(headers[j]) //seleziono la prop di indice j
                            .SetValue(entry, // oggetto su cui lavorare il nuovo oggetto T  che ho creato
                            Convert    //inizio a convertire il valore
                            .ChangeType(col, //   singola cella del CSV (il valore da settare )
                            entry.GetType().GetProperty(headers[j]) // Prende la property col nome del Header corrente 
                                .PropertyType)//ritorna il tipo del property 
                            ); //converto il valore del csv con il tipo dellap property che ho considerato

                        j++;
                    }
                    list.Add(entry);
                }
            }
            else Console.WriteLine("le proprietà nel file non corrispondono a proprietà oggetto");

            return list;
        }

    }
}
