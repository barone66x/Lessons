using System;
using System.Collections.Generic;
using System.Linq;

namespace MediaPlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Content> contents = new List<Content>();
            List<Movie> movies = new List<Movie>() { new("Terminator", 120, "aaa", "1920x1080"), new("Titanic", 180, "bbbb", "1920x1080"), new("Harry Potter", 150, "ccc", "1920x1080)") };
            List<Song> songs = new List<Song>() { new("In The End", 3, "Linkin Park", "320"), new("Smooth Criminal", 4, "Michael Jackson", "320"), new("Demons", 4, "Imagine Dragons", "320") };

            Console.WriteLine("Program MediaPlayer");
            Console.WriteLine();
            Console.WriteLine();

            Menu.Choice();
            string scelta = Console.ReadLine();


            switch (scelta)
            {
                case "m":
                    //content = (List<Content>)movies.Cast<Content>();
                    // List<Content> contents = movies.Cast<Content>().ToList();
                    contents = movies.Cast<Content>().ToList();

                    break;

                case "s":
                    contents = songs.Cast<Content>().ToList();

                    break;

                default:
                    Console.WriteLine("incorrect choice");
                    return;


            }

            Player player = new Player(contents);
            player.Start();






        }
    }
}
