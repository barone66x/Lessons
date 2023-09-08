using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer
{
    internal class Song : Content
    {

        internal string quality;


        public Song(string title, int time, string author, string quality) : base(title, time, "", author)
        {
            this.title = title;
            this.time = time;
            this.type = "Song";
            this.author = author;
            this.quality = quality;

        }

        public override string ShowProp()
        {
            return quality;
        }
    }
}
