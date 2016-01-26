using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_4_Koti
{
    class Disc :Object
    {
        public string Shape { get; set; }
        public string Small  { get; set; }

        public Disc()
        {
        }

        public Disc (string shape, string small)
        {
            Shape = shape;
            Small = small;
        }

        public void Discs()
        {
            Console.WriteLine ("All are discs ");
        }

        public override string ToString()
        {
            return Shape + " " + Small + " ";
        }
    }
}
