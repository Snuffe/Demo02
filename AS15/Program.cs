﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS15
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Anna puunkorkeus > ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(String.Concat(Enumerable.Repeat( "*", i)));
                Console.Write(String.Concat(Enumerable.Repeat("* \n", 2)));
            }

        }
    }
}
