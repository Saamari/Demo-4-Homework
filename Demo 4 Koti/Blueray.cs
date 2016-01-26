using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_4_Koti
{
    class Blueray : Disc
    {
        public string Best { get; set; }

        public Blueray()
        {
        }           

        public Blueray(string shape, string small , string best)
            :base (shape ,small )
        {
            Best = best;
        }

        public void Blueraybest()
        {
            Console.WriteLine("Blueray is better than DVD");
        }

        public override string ToString()
        {
            return base.ToString() + " " + Best;
        }
    }

}
