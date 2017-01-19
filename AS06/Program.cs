using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS06
{
    class Program
    {
        static void Main(string[] args)
        {

            double matka;

            Console.Write("Anna Matka > ");
            matka = double.Parse(Console.ReadLine());

            double bensa = ((matka / 100)* 7.02);
            double raha = (bensa *  1.595);

            Console.Write("Bensan määrä > " + bensa + "\n" + "rahaa menee > " + raha + "\n");

        }
    }
}
