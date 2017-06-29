using System;

namespace Sequence
{
    class CheckSequence
    {
        const string INSTRUCTIONS1LINE = "Enter a sequance of nubers. ";
        const string INSTRUCTIONS2LINE = "Use Space to devide numbers. Use Enter to finish input.";
        public int[] EnterSequense ()
        {
            bool successInput = false;
            int[] sequanceNumbers = null;
            while (!successInput)
            {
                successInput = true;
                Console.WriteLine(INSTRUCTIONS1LINE);
                Console.WriteLine(INSTRUCTIONS2LINE);
                string[] inputNumbers;
                try
                {
                    inputNumbers = Console.ReadLine().Split();
                    sequanceNumbers = new int[inputNumbers.Length];
                    for (int i = 0; i < inputNumbers.Length; i++)
                    {
                        sequanceNumbers[i] = int.Parse(inputNumbers[i]);
                    }
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine("Error " + ex.Message);
                    successInput = false;
                }
            }
            return sequanceNumbers;
        }         
        public bool IsUndecreasing(int[] numbers)
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