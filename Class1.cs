using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_Day5
{
    internal class Class1
    {
        public const int MAX_FLIP = 15;
        public static void FlipCoin()
        {

            int heads = 0, tails = 0, result = 0;

            for (int i = 0; i < MAX_FLIP; i++)
            {
                Random random = new Random();
                result = random.Next(0, 2);

                if (result == 1)
                {
                    heads++;
                }
                else
                {
                    tails++;
                }
            }
            Console.WriteLine("head flipped " + heads);
            Console.WriteLine("tail flipped " + tails);
            int total_flipped = heads + tails;
            Console.WriteLine("Total no of flips " + total_flipped);
            int percentage1 = (heads / total_flipped) * 100;
            int percentage2 = (tails / total_flipped) * 100;
            Console.WriteLine(percentage1);
            Console.WriteLine(percentage2);
        }
    }
}