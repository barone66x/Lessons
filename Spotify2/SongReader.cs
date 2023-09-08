using MediaPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Spotify2
{
    internal class SongReader
    {
        //private List<Content> content;
        // private string songInput;
        private int visualInput;
        private string choice;
        private string menuChoice;
        private Song inPlaying;
        private List<Song> songs;

        public SongReader(List<Song> s)
        {
            songs = s;
        }

        public void ShowArtists()
        {
            //NON è un dizionario, E' una TUPLA
            List<string> artists = (
                from a in songs
                select new { a.artist }).Select(a => a.artist).Distinct().OrderBy(a => a).ToList();




            int i = 0;
            foreach (var item in artists) //stampa le due proprietà che ho estratto
            {

                Console.WriteLine($" {i}  {item} ");
                i += 1;

            }
            Menu.ChoseNumber();
            visualInput = int.Parse(Console.ReadLine());
            string selectedAlbum = artists[visualInput];
            ShowSongs(selectedAlbum);
        }






        //public void Start()
        //{
        //    Console.WriteLine("- - - - - - - - - - - - - - ");
        //    ShowList();
        //    Console.WriteLine("choose number of content");
        //    numberSongInput = int.Parse(Console.ReadLine());

        //    CurrentPlay(numberSongInput);
        //    Console.WriteLine("- - - - - - - - - - - - - - ");



        //}

        public void ShowSongs(string album)
        {
            //Console.WriteLine("- - - - - - - - - - - - - - ");
            //int i = 0;
            //foreach (var item in songs)
            //{

            //    Console.WriteLine($"{i}  {item.title}");
            //    i += 1;

            //}
            //Console.WriteLine("- - - - - - - - - - - - - - ");


            List<string> titles = (
                from a in songs
                where a.album == album
                select new { a.title, a.album }).Select(a => a.title).Distinct().OrderBy(a => a).ToList();




            int i = 0;
            foreach (var item in titles) //stampa le due proprietà che ho estratto
            {

                Console.WriteLine($" {i}  {item} ");
                i += 1;

            }
            Menu.ChoseNumber();
            visualInput = int.Parse(Console.ReadLine());
            CurrentPlay(visualInput);

        }


        public void CurrentPlay(int numberInput)
        {
            Console.WriteLine("- - - - - - - - - - - - - - ");
            inPlaying = songs[numberInput];
            Console.WriteLine($"Now in Playing: {inPlaying.title}");
            Console.WriteLine("- - - - - - - - - - - - - - ");
            Menu.ShowMenu();
            menuChoice = Scegli();
            //NextAction(menuChoice);




        }


        //public void Next()
        //{
        //    if (numberSongInput < songs.Count - 1)
        //    {
        //        numberSongInput += 1;

        //    }
        //    else
        //    {
        //        numberSongInput = 0;
        //    }

        //    CurrentPlay(numberSongInput);


        //}

        //public void Previous()

        //{
        //    if (numberSongInput > 0)
        //    {
        //        numberSongInput -= 1;

        //    }
        //    else
        //    {
        //        numberSongInput = songs.Count - 1;
        //    }

        //    CurrentPlay(numberSongInput);

        //}

        //public void Pause()
        //{
        //    Console.Write("Now In Pause");
        //    Menu.ShowMenu();
        //    menuChoice = Scegli();
        //    NextAction(menuChoice);



        //}


        public void Exit()
        {
            return;
        }

        public string Scegli()
        {
            //Menu.ShowMenu();
            menuChoice = Console.ReadLine();
            return menuChoice;
        }

        //public void NextAction(string choice)
        //{
        //    switch (choice)

        //    {
        //        case "f":
        //            Next();

        //            break;
        //        case "b":
        //            Previous(); break;
        //        case "p":
        //            Pause(); break;
        //        case "e":
        //            Exit(); break;
        //        default:
        //            Console.WriteLine("scelta sbagliata");
        //            return;

        //    }

    }
}

