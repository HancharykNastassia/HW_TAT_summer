using System;

namespace Fibonachchi
{
    class FibonachchiMain
    {
        static void Main (string [] args)
        {
            try
            {
                Console.WriteLine("Enter number");
                int number = int.Parse(Console.ReadLine());
                bool f = false;
                if (number == 0 || number == 1)
                    Console.WriteLine(number.ToString() + " is in the Fibonacci sequence");
                else
                {
                    int[] fib = new int[] { 0, 1, 1 };
                    while (fib[2] < number)
                    {
                        fib[0] = fib[1];
                        fib[1] = fib[2];
                        fib[2] = fib[0] + fib[1];
                        f = (fib[2] == number);
                    }
                    if (f)
                        Console.WriteLine(number.ToString() + " is in the Fibonacci sequence");
                    else
                        Console.WriteLine(number.ToString() + " is in the Fibonacci sequence");
                }                
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.WriteLine("Press any key for exit");
            Console.ReadKey();
        }
    }
}
