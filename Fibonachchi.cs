using System;

namespace Fibonachchi
{
    class FibonachchiMain
    {
        static void Main (string [] args)
        {
            try
            {
                bool isfibonacci = false;

                Console.WriteLine("Enter number");
                int number = int.Parse(Console.ReadLine());
                if ((number == 0) || (number == 1))
                    Console.WriteLine(number.ToString() + " is in the Fibonacci sequence");
                else
                {
                    int[] fibonaccinumber = new int[] { 0, 1, 1 };

                    while (fibonaccinumber[2] < number)
                    {
                        fibonaccinumber[0] = fibonaccinumber[1];
                        fibonaccinumber[1] = fibonaccinumber[2];
                        fibonaccinumber[2] = fibonaccinumber[0] + fibonaccinumber[1];
                        isfibonacci = (fibonaccinumber[2] == number);
                    }
                    if (isfibonacci)
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
