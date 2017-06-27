using System;

namespace Sequance
{
    class EntryPoint
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
                    Console.WriteLine("Enter a sequance of nubers.\nUse Space to devide numbers.\n" +
                                      "Use Enter to finish input.");
                    string[] inputNumbers = Console.ReadLine().Split();
                    int[] sequanceNumbers = new int[inputNumbers.Length];
                    for (int i = 0; i < inputNumbers.Length; i++)
                    {
                        sequanceNumbers[i] = int.Parse(inputNumbers[i]);
                    }
                    if (goodInput)
                    {
                        for (int i = 1; i < inputNumbers.Length; i++)
                        {
                            if (sequanceNumbers[i] < sequanceNumbers[i-1])
                            {
                                isUndecreaseSequanse = false;
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