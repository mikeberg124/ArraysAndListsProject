using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            int[] myArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // Create an int Array and populate numbers 1-10


            var evens = new List<int>();
            var odds = new List<int>();
            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            foreach (var num in myArray)
            {
                if (num %2 ==0)
                {
                    evens.Add(num);
                }
                else
                {
                    odds.Add(num);
                }
            }
            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */



            foreach (var item in evens)
            {
                Console.WriteLine($"{item} is an even number");
            }
            foreach (var item in odds)
            {
                Console.WriteLine($"{item} is an odd number");
            }
            

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
        }
    }
}
