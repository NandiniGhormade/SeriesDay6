using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_Day5
{
    internal class Class7
    {
        public static void Power()
        {
            int n;
            Console.WriteLine("enter the power");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("power of two is : " + Math.Pow(2, i));
            }

        }
    }
}