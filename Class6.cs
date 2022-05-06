using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_Day5
{
    internal class Class6
    {
        public static void VowelConsonant()
        {
            char ch;
            Console.WriteLine("enter the alphabet");

            ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'A' || ch == 'e' || ch == 'E' || ch == 'i' || ch == 'I' || ch == 'o' || ch == 'O' || ch == 'u' || ch == 'U')
            {
                Console.WriteLine(ch + " is a vowel ");
            }
            else
            {
                Console.WriteLine(ch + " is Consonant ");
            }
        }
    }
}