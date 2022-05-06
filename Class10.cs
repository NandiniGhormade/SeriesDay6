using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_Day5
{
    internal class Class10
    {
        public static void QuoRem()
        {
            int dividend, divisor;

            Console.WriteLine("Enter the dividend");
            dividend = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the divisor");
            divisor = int.Parse(Console.ReadLine());

            int Quotient = dividend / divisor;
            int Remainder = dividend % divisor;

            Console.WriteLine("Reaminder is " + Remainder);
            Console.WriteLine("quotient is " + Quotient);
        }
    }
}