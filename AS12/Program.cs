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
            int num1 = int.Parse(Console.ReadLine());
            luvut[0] = num1;


            Console.Write("Anna kokonaisnumero " + n + " > ", n++);
            int num2 = int.Parse(Console.ReadLine());
            luvut[1] = num2;

            Console.Write("Anna kokonaisnumero " + n + " > ", n++);
            int num3 = int.Parse(Console.ReadLine());
            luvut[2] = num3;

            Console.Write("Anna kokonaisnumero " + n + " > ", n++);
            int num4 = int.Parse(Console.ReadLine());
            luvut[3] = num4;

            Console.Write("Anna kokonaisnumero " + n + " > ");
            int num5 = int.Parse(Console.ReadLine());
            luvut[4] = num5;

            Array.Reverse(luvut);

            foreach (int value in luvut)
            {
                Console.WriteLine(value);
            }
        }
        }
    }
