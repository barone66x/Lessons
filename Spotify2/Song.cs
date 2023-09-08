using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify2
{
    public class Song
    {
        public string artist;
        public string album;
        public string genre;
        public string title;
        public string times;

        public Song(string artist, string album, string genre, string title, string times)
        {
            this.artist = artist;
            this.album = album;
            this.genre = genre;
            this.title = title;
            this.times = times;
        }

    }
}
