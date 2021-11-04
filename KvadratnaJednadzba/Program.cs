using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KvadratnaJednadzba
{
    class Program
    {
        static void Main(string[] args)
        {
            QuadraticEquation qe = new QuadraticEquation(1, 2, -3);
            //Console.WriteLine(qe.A);

            var roots = qe.Roots;
            Console.WriteLine($"The roots of the first equation are: {roots[0]} and {roots[1]}");

            QuadraticEquation qe2 = new QuadraticEquation(-1, 2, -1);
            var roots2 = qe2.Roots;
            Console.WriteLine($"The roots of the second equation are: {roots2[0]} and {roots2[1]}");
            Console.ReadKey(false);

        }
    }
}
