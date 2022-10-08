using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongLib
{
    public abstract class Song
    {
        public int year;
        public string lyrics;
        public string composer;
        public string artist;

        public string Name
        {
            get;
            set;
        }

        public abstract void Play();

        public virtual void Copy()
        {

        }

        public void Dance()
        {
            
        }

        public void Sing()
        {

        }
    }

    public class TapeSong : Song
    {

    }
}
