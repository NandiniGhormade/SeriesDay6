using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_Day5
{
    internal class Class5
    {
        public static void Harmonic()
        {
            int i, n;
            double sum = 0.0;

            Console.WriteLine("Enter the number");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("1/{0} + ", i);
                sum = sum + 1 / (float)i;
            }
            Console.WriteLine("Sum of H.P. is : ", sum);
        }
    }
}