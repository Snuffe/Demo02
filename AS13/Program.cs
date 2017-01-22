using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS13
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] points = new int[5];
            
            Console.Write("Anna Tyylipisteet  > ");
            int num1 = int.Parse(Console.ReadLine());
            points[0] = num1;


            Console.Write("Anna Tyylipisteet > ");
            int num2 = int.Parse(Console.ReadLine());
            points[1] = num2;

            Console.Write("Anna Tyylipisteet > ");
            int num3 = int.Parse(Console.ReadLine());
            points[2] = num3;

            Console.Write("Anna Tyylipisteet  > ");
            int num4 = int.Parse(Console.ReadLine());
            points[3] = num4;

            Console.Write("Anna Tyylipisteet > ");
            int num5 = int.Parse(Console.ReadLine());
            points[4] = num5;

            int max = points.Max();
            int min = points.Min();
            int sum = points.Sum();
            int score = sum - min - max;

            Console.WriteLine("Kokonaispisteet ovat " +  score);

        }
    }
}
