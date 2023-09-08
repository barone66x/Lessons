using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer
{
    internal abstract class Content
    {
        internal string title;
        internal int time;
        internal string type;
        internal string author;

        public Content(string title, int time, string type, string author)
        {
            this.title = title;
            this.time = time;
            this.type = type;
            this.author = author;

        }

        public abstract string ShowProp();


    }
}
