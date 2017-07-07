using System;

namespace Sequence
{
    class SequenceInputer
    {
        const string INSTRUCTIONS1LINE = "Enter a sequance of nubers. ";
        const string INSTRUCTIONS2LINE = "Use Space to devide numbers. Use Enter to finish input.";
        bool successInput;
        public bool SuccessInput
        {
            get { return successInput; }
            set { successInput = value; }
        }
        public string[] EnterSequense()
        {
            Console.WriteLine(INSTRUCTIONS1LINE);
            Console.WriteLine(INSTRUCTIONS2LINE);
            string[] inputNumbers = Console.ReadLine().Split();
            return inputNumbers;
        }
        public int[] ParseNubmersOfSequence (String[] inputNumbers)
        {
            int[] sequenceNumbers = new int[inputNumbers.Length];
            for (int i = 0; i < inputNumbers.Length; i++)
            {
               sequenceNumbers[i] = int.Parse(inputNumbers[i]);
            }
            return sequenceNumbers;
        }
    }
}