using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_7
{
    class Plant : Object
    {
       public string Leaf { get; set; }
       public string Oxygen { get; set; }

        public Plant()
            {
            }

            public Plant (string leaf , string oxygen)
             {
            Leaf = leaf;
            Oxygen = oxygen;
             }
            
        public void Plants()
        {
            Console.WriteLine("All plants produce oxygen ");

        }

        public override string ToString()
        {
            return Leaf + " " + Oxygen + " ";
        }
    }
}
