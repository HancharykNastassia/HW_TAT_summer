using System;

namespace Sequence
{
    class IsSequenceUndecrease
    {
        public int[] EnterSequense ()
        {
            bool goodInput = false;
            string instruction = "Enter a sequance of nubers.\nUse Space to devide numbers.\n" +
                                 "Use Enter to finish input.";
            while (!goodInput)
            {              
                try
                {
                    Console.WriteLine(instruction);
                    string[] inputNumbers = Console.ReadLine().Split();
                    int[] sequanceNumbers = new int[inputNumbers.Length];
                    for (int i = 0; i < inputNumbers.Length; i++)
                    {
                        sequanceNumbers[i] = int.Parse(inputNumbers[i]);
                    }
                    return sequanceNumbers;
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
            return null;
        }
        public bool isUndecreasing(int[] numbers)
        {
            bool isUndecreasingSequence = true;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    isUndecreasingSequence = false;
                    break;
                }
            }
            return isUndecreasingSequence;
        }
    }
}