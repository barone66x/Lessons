﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify3
{
    internal class FileLoader
    {
        public static List<Song> Reader()
        {
            var path = @"C:\Users\mattia.ligreci\Documents\Test\databaseCanzoni.csv";
            List<Song> songs = new List<Song>();

            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    var values = line.Split(',');
                    Song song = new Song(values[0], values[1], values[2], values[3], values[4]);
                    songs.Add(song);
                }
                return songs;
            }


        }
    }
}
