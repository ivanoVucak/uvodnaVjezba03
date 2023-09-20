using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uvodnVjezba03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            double najduzaStranica = 0;
            double kraca1 = 0;
            double kraca2 = 0;
            double p = 0;
            ;

            opet:
            Console.Write("molim upiši prvi broj: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("molim upiši prvi broj: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.Write("molim upiši prvi broj: ");
            z = Convert.ToInt32(Console.ReadLine());

            if (x <= 0 || y <= 0 || z <= 0)
            {
                Console.WriteLine("Stranice moraju biti veće od 0! ");
                goto opet;
            }

            if (x > y && x > z) {
                najduzaStranica = x;
                kraca1 = y;
                kraca2 = z;
            }
            if (y > x && y > z)
            {
                najduzaStranica = y;
                kraca1 = z;
                kraca2 = x;
            }
            if (z > y && z > x)
            {
                najduzaStranica = z;
                kraca1 = x;
                kraca2 = y;
            }

            p = (kraca1 * kraca1) + (kraca2 * kraca2);
            if (p == najduzaStranica) {
                Console.WriteLine("To je pravokutni trokut");
            }
            else {
                Console.WriteLine("To nije pravokutni trokut");
            }
            Console.ReadKey();


        }
    }
}
