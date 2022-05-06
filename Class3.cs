using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_Day5
{
    internal class Class3
    {
        public static void LeapYear()
        {
            int year;
            Console.WriteLine("Enter the Year");
            year = int.Parse(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("Year is a Leap Year");
            }
            else
            {
                Console.WriteLine("Year is an Ordinary Year");
            }
        }
    }
}