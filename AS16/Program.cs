using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS16
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int luku = rnd.Next(1, 101);
            Console.Write("Arvaa arvottu luku \n");

            Boolean gameon = true;
            while (gameon) {
                Console.Write("Anna numero > ");
                int arvaus = int.Parse(Console.ReadLine());

                if (arvaus > luku)
                {

                    Console.Write("luku on pienempi \n");

                }

                else if (arvaus < luku)
                {

                    Console.Write("luku on suurempi \n ");

                }

                else {
                    Console.Write("oikein, luku oli : " + luku + "\n");
                    break;
                }

            }
            

        }
    }
}
