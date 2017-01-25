using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna tahtirivien lukumaara: ");
            int n = int.Parse(Console.ReadLine());
       
            for (int i = 1; i<=n;  i++)
            {
               
                Console.WriteLine(String.Concat(Enumerable.Repeat("*", i)));
            }

        }
    }
}
// tai
//for (int i = 0; i < n; i++){
//    for(int j = 0; <=i; j++)
//    {
//        console.Write("*");
//    }
//    Console.WriteLine();
//    }
