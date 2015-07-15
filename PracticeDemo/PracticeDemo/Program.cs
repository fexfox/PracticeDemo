using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PracticeDemo
{
    internal static class Program
    {
        //Using the easiest way to complete the functions below.
        private static void Main(string[] args)
        {
            //Do not change the Code Here.
            Console.WriteLine("Function1:" + Function1().Aggregate("", (current, item) => current + (item.ToString() + " ")));
            Console.WriteLine("Function2:" + Function2().Aggregate("", (current, item) => current + (item.ToString() + " ")));
            Console.WriteLine("Function3:" + Function3(12345));
            Console.ReadLine();
        }

        private static IEnumerable<int> Function1()
        {
            var list = new List<int> { 12, 3, 4, 99, -3, 0, 8, 7, 43, 22 };

            //sort the arraylist from lowest to highest.
            //------------------Code Below.---------------------


            //--------------------------------------------------
            return list;
        }

        private static IEnumerable<int> Function2()
        {
            var list = new List<int> { 12, 3, 4, 99, -3, 0, 8, 7, 43, 22 };
            //sort the arraylist from highest to lowest
            //------------------Code Below.---------------------


            //--------------------------------------------------
            return list;
        }

        private static int Function3(uint number)
        {
            int count=-1;
            //给定一个正整数n， 求把这个正整数表示成二进制数后1的个数。
            //n is a positive integers,count the number of '1' when it converts to a bindary number.
            //------------------Code Below.---------------------


            //--------------------------------------------------
            return count;
        }
    }
}