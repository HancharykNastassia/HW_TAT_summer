using System;

namespace Sequance
{
    class SequanceMain
    {
        static void Main (string [] args)
        {
            bool goodInput = false;
            while (!goodInput)
            {
                try
                {
                    goodInput = true;
                    bool isUndecreaseSequanse = true;
                    Console.WriteLine("Enter a sequance of nubers.");
                    Console.WriteLine("Use Space to devide numbers.");
                    Console.WriteLine("Use Enter to finish input.");
                    string[] inputNumbers = Console.ReadLine().Split();
                    int length = inputNumbers.Length;
                    int[] sequanceNumbers = new int[length];
                    for (int i = 0; i < length; i++)
                    {
                        sequanceNumbers[i] = int.Parse(inputNumbers[i]);
                    }
                    if (goodInput)
                    {
                        for (int i = 1; i < length; i++)
                        {
                            if (sequanceNumbers[i] < sequanceNumbers[i-1])
                            {
                                isUndecreaseSequanse = false;
                            }
                            if (!isUndecreaseSequanse)
                            {
                                Console.WriteLine("The sequance is not undecreasing.");
                                break;
                            }
                        }
                        if (isUndecreaseSequanse)
                        {
                            Console.WriteLine("The sequance is undecreasing.");
                        }
                    }
                }
                catch (System.FormatException ex)
                {
                    Console.WriteLine("Error " + ex.Message);
                    goodInput = false;
                }
                catch (System.OverflowException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    goodInput = false;
                }
                catch (System.ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    goodInput = false;
                }
            }
            Console.WriteLine("Press any key for exit");
            Console.ReadKey();
        }
    }
}