using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS5_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sekunnit = 3661;

            int tunnit = sekunnit / 3600;
            int min = sekunnit / 60 - tunnit * 60;
            int sek = sekunnit % 60;

            Console.Write(tunnit, min, sek);

        }
    }
}
