using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_Day5
{
    internal class Class4
    {
        public static void SwapNumbers()
        {
            int a, b, temp;
            Console.WriteLine("Entee the first number");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            b = int.Parse(Console.ReadLine());

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("After swapping : ");
            Console.WriteLine("first number is : " + a);
            Console.WriteLine("second number is : " + b);
        }
    }
}