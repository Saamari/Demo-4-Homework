using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Plant plant = new Plant();
            plant.Leaf = "Leafs are green";
            plant.Oxygen = "Plants produce oxygen ";
            Console.WriteLine(plant.ToString());

            Bush bush = new Bush();
            bush.Fuzzy = " Bushes are fuzzy";
            Console.WriteLine(bush.ToString());

            Tree tree = new Tree();
            tree.Tall = "Trees are very tall";
            Console.WriteLine(tree.ToString());


        }
    }
}
