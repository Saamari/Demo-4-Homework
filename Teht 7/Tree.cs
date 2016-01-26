using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_7
{
    class Tree : Plant
    {
        public string Tall { get; set; }

        public Tree()
        {
        }

        public Tree(string leaf, string oxygen, string tall)
            : base(leaf, oxygen)
            {
            Tall = tall;
        }

        public void Fuzzybush()
        {
            Console.WriteLine("Tree is taller than bush ");
        }
        public override string ToString()
        {
            return base.ToString() + " " + Tall;
        }

    }
}
