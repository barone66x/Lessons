using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Album : Raccolta
    {
        public string NomeAlbum;
        public List<Canzone> listaCanzoniAlbum;
        public Genere genereAlbum;
        public Album()
        {
            listaCanzoniAlbum = new List<Canzone>();
        }
    }
}
