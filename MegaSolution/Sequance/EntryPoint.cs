using System;

namespace Sequence
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            const string NOTASEQUENCEMESSAGE = "One number is not a sequence. Please enter a sequence.";
            const string POSITIVEMESSAGE = "The sequence is undecreasing";
            const string NEGATIVEMESSAGE = "The sequence is not undecreasing";
            var enterSequence = new SequenceInputer(false);
            var checkSequence = new CheckSequence();
            int[] sequence;
            bool isUndecrease = true;
            const int minSequenceLength = 2;

            while (!enterSequence.SuccessInput)
            {
                try
                {
                    enterSequence.SuccessInput = true;
                    sequence = enterSequence.ParseNubmersOfSequence(enterSequence.EnterSequense());
                    while (sequence.Length < minSequenceLength)
                    {
                        Console.WriteLine(NOTASEQUENCEMESSAGE);
                        sequence = enterSequence.ParseNubmersOfSequence(enterSequence.EnterSequense());
                    }
                    isUndecrease = checkSequence.IsUnDecreasing(sequence);
                    Console.WriteLine(isUndecrease ? POSITIVEMESSAGE : NEGATIVEMESSAGE);
                }
                catch (System.Exception)
                {
                    enterSequence.SuccessInput = false;
                }
            }
            Console.WriteLine("Press any key for exit");
            Console.ReadKey();
        }
    }
}