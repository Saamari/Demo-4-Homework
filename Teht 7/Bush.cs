using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_7
{
    class Bush : Plant
    {
        public string Fuzzy { get; set; }

        public Bush()
        {
        }

        public Bush(string leaf, string oxygen, string fuzzy)
            : base(leaf, oxygen)
            {
            Fuzzy = fuzzy;
            }

        public void Fuzzybush()
        {
            Console.WriteLine("Bush is fuzzy ");
        }
        public override string ToString()
        {
            return base.ToString() + " " + Fuzzy;
        }


    }
}
