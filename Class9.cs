using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_Day5
{
    internal class Class9
    {
        public static void PrimeFactorization()
        {
            int i, num;
            Console.WriteLine("Please enter your integer: ");
            num = int.Parse(Console.ReadLine());
            for (i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                    num = num / i;
                }
            }
            Console.WriteLine(num);

        }
    }
}