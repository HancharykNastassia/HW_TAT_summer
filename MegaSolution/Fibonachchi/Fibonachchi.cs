﻿using System;

namespace Fibonachchi
{
    class FibonachchiMain
    {
        static void Main(string[] args)
        {
            int number = -1;
            while (number < 0)
            {
                Console.WriteLine("Enter not negative number");
                try
                {
                    number = int.Parse(Console.ReadLine());
                }
                catch (System.FormatException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    number = -1;
                }
                catch (System.OverflowException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    number = -1;
                }
            }
            bool isFibonacci = false;
            if ((number == 0) || (number == 1))
            { 
                Console.WriteLine(number.ToString() + " is in the Fibonacci sequence");
            }
            else
            {
                int[] fibonacciNumber = new int[] { 0, 1, 1 };
                while (fibonacciNumber[2] < number)
                {
                    fibonacciNumber[0] = fibonacciNumber[1];
                    fibonacciNumber[1] = fibonacciNumber[2];
                    fibonacciNumber[2] = fibonacciNumber[0] + fibonacciNumber[1];
                    isFibonacci = (fibonacciNumber[2] == number);
                }
                if (isFibonacci)
                {
                    Console.WriteLine(number.ToString() + " is in the Fibonacci sequence");
                }
                else
                {
                    Console.WriteLine(number.ToString() + " is not in the Fibonacci sequence");
                }
            }
            Console.WriteLine("Press any key for exit");
            Console.ReadKey();
        }
    }
}
