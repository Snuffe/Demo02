using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS12
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] luvut = new int[5];
            int n = 1;
            
            Console.Write("Anna kokonaisnumero " + n + " > ", n++);
            luvut[0] = int.Parse(Console.ReadLine());

            Console.Write("Anna kokonaisnumero " + n + " > ", n++);
            luvut[1] = int.Parse(Console.ReadLine());

            Console.Write("Anna kokonaisnumero " + n + " > ", n++);
            luvut[2] = int.Parse(Console.ReadLine());

            Console.Write("Anna kokonaisnumero " + n + " > ", n++);
            luvut[3] = int.Parse(Console.ReadLine());

            Console.Write("Anna kokonaisnumero " + n + " > ");
            luvut[4] = int.Parse(Console.ReadLine());

            Array.Reverse(luvut);

            foreach (int value in luvut)
            {
                Console.WriteLine(value);
            }
        }
        }
    }
