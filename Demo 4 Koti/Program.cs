using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_4_Koti
{
    class Program
    {
        static void Main(string[] args)
        {
            Disc disc = new Disc();

            disc.Shape = " Disc is round ";
            disc.Small = " Disc is small ";
            Console.WriteLine(disc.ToString());

            Cd cd = new Cd(" Round", " small ", " Usually music", "and 1-20 songs");
            Console.WriteLine(cd.ToString());

            Dvd dvd = new Dvd(" Round", " small ", " Usually movies in DVD");
            Console.WriteLine(dvd.ToString());

            Blueray blueray = new Blueray(" Round", " small ", " Blueray is better than DVD");
            Console.WriteLine(blueray.ToString());

            Console.WriteLine(" MORO MORO");
            Console.ReadLine();









        }
    }
}
