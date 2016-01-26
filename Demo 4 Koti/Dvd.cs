using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_4_Koti
{
    class Dvd : Disc
    {
        public string Movie { get; set; }

        public Dvd()
        {
        }

        public Dvd(string shape , string small , string movie)
                :base (shape , small)
        {
            Movie = movie;
        }
      
            public void Dvdmovie()
        {
            Console.WriteLine("Contain usually movies");
        }

        public override string ToString()
        {
            return base.ToString() +" " + Movie;
        }

    }

}
