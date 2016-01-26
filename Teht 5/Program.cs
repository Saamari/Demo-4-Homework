using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Radio radio = new Radio();
            bool onoff = true;
            int input;
            do
            {
                Console.WriteLine();
                if (radio.OnOff == true)
                    Console.WriteLine("Radio on");
                else
                    Console.WriteLine("Radio off");
                Console.WriteLine("Radio volume {0} frequency {1} ", radio.Volume, radio.Frequency);
                Console.WriteLine("1 On/Off ");
                Console.WriteLine("2. Volume");
                Console.WriteLine("3. Frequency ");
                Console.WriteLine("4. Shut down ");
                input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        if (radio.OnOff == false)
                            radio.OnOff = true;
                        else
                            radio.OnOff = false;
                        break;
                    case 2:
                        {
                            Console.Write("Set volume 0-9");
                            radio.Volume = int.Parse(Console.ReadLine());
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Set frequency 2000,0-26000,0");
                            radio.Frequency = double.Parse(Console.ReadLine());
                            break;
                        }
                    case 4:
                        onoff = false;
                        break;
                }
            } while (onoff == true);
                     

  
         }
    }
}
                 
                
             
        


            
           
            
        
    


