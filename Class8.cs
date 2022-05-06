using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_Day5
{
    internal class Class8
    {
        public static void MaxNumber()
        {
            int a, b, c;
            Console.WriteLine("enter the first num");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the second num");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the third num");
            c = int.Parse(Console.ReadLine());

            int Max = a;

            if (Max < b)
            {
                Console.WriteLine(Max = b);
            }
            else if (Max < c)
            {
                Console.WriteLine(Max = c);
            }

            Console.WriteLine("max number is " + Max);
        }
    }
}