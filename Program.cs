/*
Pandigital Numbers from Coding Challenges
by Silvio Duka

Last modified date: 2018-02-25 

If a number contains each of the digits from 0 to 9 at least once (0 not being the leading digit), it is considered to be pandigital. 

For example, 1076398452 is pandigital. 
Similarly, 11145689723232309899 is also pandigital. 

Tasks: 
(Easy) Write a program to verify whether a given number is pandigital or not. 
(Hard) In addition to verifying the number being pandigital, display the number of times each digit appears in that number.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandigitalNumbersHard
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = 123405086780999; //Insert an integer number

            int[] digits = new int[10]; //Array containing appearance of single digit

            long t = number;

            while (t != 0)
            {
                digits[t % 10]++;

                t = t / 10;
            }

            bool b = true;

            for(int i = 0; i < 10; i++)
            {
                b &= (digits[i] != 0);

                Console.WriteLine($"The digit {i} appears {digits[i]} times.");
            }

            Console.WriteLine($"\nThe number {number} {((b) ? "is" : "is not")} an Pandigital number.");
        }
    }
}

