using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer
{
    internal class Movie : Content
    {

        internal string resolution;

        public Movie(string title, int time, string author, string resolution) : base(title, time, "", author)
        {
            this.title = title;
            this.time = time;
            this.type = "Movie";
            this.author = author;
            this.resolution = resolution;

        }

        public override string ShowProp()
        {
            return resolution;
        }
    }
}
