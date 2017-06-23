using System;

namespace Fibonachchi
{
    class FibonachchiMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int number = 0;
            try
            {
                number = int.Parse(Console.ReadLine());
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("Enter a number please.");
                number = int.Parse(Console.ReadLine());
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
