using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS07
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Anna vuosiluku > ");
            int vuosi = int.Parse(Console.ReadLine());

            if (vuosi % 4 == 0 || vuosi % 400 == 0) {
                Console.Write("Vuosi on karkausvuosi");
            }

            else {
                Console.Write("Vuosi ei ole karkausvuosi \n");
            }

            



        }
    }
}
