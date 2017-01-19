using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS08
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Anna kokonaisnumero1 > ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Anna kokonaisnumero2 > ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.Write("Anna kokonaisnumero3 > ");
            int numero3 = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(Math.Max(numero1, numero2), numero3));

        }
    }
}
