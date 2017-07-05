using System;

using System;

namespace Sequence
{
    class InputClass
    {
        const string INSTRUCTIONS1LINE = "Enter a sequance of nubers. ";
        const string INSTRUCTIONS2LINE = "Use Space to devide numbers. Use Enter to finish input.";
        public int[] EnterSequense()
        {
            bool successInput = false;
            int[] sequanceNumbers = { 0 };
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
                catch (System.FormatException ex)
                {
                    Console.WriteLine("Error " + ex.Message);
                    successInput = false;
                }
                catch (System.OverflowException ex)
                {
                    Console.WriteLine("Error " + ex.Message);
                    successInput = false;
                }
            }
            return sequanceNumbers;
        }
    }
}