using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_5
{
    class Radio
    {


        private readonly int maxVolume = 9;
        private readonly double maxFreq = 26000.0;
        private readonly double minFreq = 2000.0;

        private int volume;
        private double frequency;

        public bool OnOff { get; set; }
        public int Volume

        {
            get
            {
                return volume;
            }
            set
            {
                if (value <= maxVolume) volume = value;

                else
                {
                    Console.Write(" Volume too high");
                    volume = maxVolume;
                }
            }
        }
        public double Frequency
        {
            get
            {
                return frequency;
            }
            set
            {
                if (value <= maxFreq && value >= minFreq) frequency = value;
                else
                {
                    Console.WriteLine("No such Frequency");
                    frequency = minFreq;

                }
            }
        }

        public override string ToString()
        {
            return "Frequency is " + Frequency + "Volume is " + Volume; 
        }
                }
            }
        





            