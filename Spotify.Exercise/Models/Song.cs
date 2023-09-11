﻿using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable

namespace Spotify.Exercise
{
    public partial class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Popularity { get; set; }
        //public int? ArtistId { get; set; }
        //public int? AlbumId { get; set; }
        //public int? GenreId { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Genre { get; set; }
        // public DateTime? CreatedAt { get; set; }

        //public virtual Album Album { get; set; }

        // public virtual Artist artista { get; set; }

        //public virtual Genre Genre { get; set; }

        public void CreateAlbum(List<Album> albums, List<Song> songs)
        {
            bool exist = false;
            //List<int> test = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
            //test = test.Distinct().ToList();
            Album test = new() { AlbumName = Album, Artist = Artist, Genre = Genre };
            foreach (Album album in albums)
            {
                if (album.AlbumName == test.AlbumName)
                {
                    exist = true;
                }
            }
            if (!exist)
            {
                albums.Add(new() { AlbumName = Album, Artist = Artist, Genre = Genre });
            }

            //  albums = albums.Select(x => x.Title).Distinct().ToList();
            int i = albums.Count() - 1;
            foreach (Album album in albums)
            {
                album.Songs = (from s in songs  //c varabiale di appoggio
                               where s.Album == album.AlbumName //condizione di estrazione
                               select s).Distinct().ToList();


            }


            //if (!albums[i].Songs.Contains(song))
            //{
            //    albums[i].Songs.Add(song);
            //}

        }








    }
}
