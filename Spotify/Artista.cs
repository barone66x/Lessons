using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Artista
    {
        public string Nome;
        List<Genere> generiAutore = new List<Genere>();
        List<Album> albumsAutore = new List<Album>();
        public Artista()
        {
            generiAutore = new List<Genere>();
            albumsAutore = new List<Album>();

        }
    }
}
