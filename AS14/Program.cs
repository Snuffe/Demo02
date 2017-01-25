using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS14
{
    class Program
    {
        static void Main(string[] args)
        {
            int nol = 0;
            int yks = 0;
            int kak = 0;
            int kol = 0;
            int nel = 0;
            int vii = 0;
            int arvosana = 0;

            while (arvosana > -1 && arvosana < 6)
            {
                Console.Write("Anna arvosana > ");
                arvosana = int.Parse(Console.ReadLine());
                switch (arvosana)
                {
                    case 0:
                        nol++;
                        continue;
                    case 1:
                        yks++;
                        continue;
                    case 2:
                        kak++;
                        continue;
                    case 3:
                        kol++;
                        continue;
                    case 4:
                        nel++;
                        continue;
                    case 5:
                        vii++;
                        continue;
                }

            }

            Console.WriteLine("Arvosanat:");
            Console.WriteLine("0:" + String.Concat(Enumerable.Repeat("*", nol)));
            Console.WriteLine("1:" + String.Concat(Enumerable.Repeat("*", yks)));
            Console.WriteLine("2:" + String.Concat(Enumerable.Repeat("*", kak)));
            Console.WriteLine("3:" + String.Concat(Enumerable.Repeat("*", kol)));
            Console.WriteLine("4:" + String.Concat(Enumerable.Repeat("*", nel)));
            Console.WriteLine("5:" + String.Concat(Enumerable.Repeat("*", vii)));

        }

        }
    }

