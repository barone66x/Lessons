using System;
using System.Collections.Generic;

namespace Spotify2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Song> songs = new List<Song>();
            songs = FileReader.Reader();
            SongReader lettore = new SongReader(songs);
            lettore.ShowArtists();
        }
    }
}
