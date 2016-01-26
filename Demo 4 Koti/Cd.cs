using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_4_Koti 
{
    class Cd : Disc
    {
        public string Music { get; set; }
        public string Songs { get; set; }

        public Cd()
        {
        }

           public Cd(string shape , string small , string music , string songs)
                : base (shape , small)
        {
            Music = music;
            Songs = songs;
        }

        public void Musiccd()
        {
            Console.WriteLine(" Cd contains usually music ");
            Console.WriteLine(" Contains 1-20 songs");
        }
        public override string ToString()
        {
            return base.ToString() +" " + Music + " " + Songs;
        }

    }
}
