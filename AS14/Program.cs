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

            int summa = 0;
            int n = 1;

            Console.Write("Anna kokonaisnumero " + n + " > ");
            int numero = int.Parse(Console.ReadLine());

            while (numero >0 ||numero <=5)
            {
                summa = (summa + numero);
                Console.Write("Anna kokonaisnumero " + n + " > ");
                numero = int.Parse(Console.ReadLine());

            }

            Console.Write("summa: " + summa + "\n");

        }
    }
}
