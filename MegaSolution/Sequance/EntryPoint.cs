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
            var enterSequence = new SequenceInputer();
            var checkSequence = new CheckSequence();
            int[] sequence;
            bool isUndecrease = true;
            const int minSequenceLength = 2;

            enterSequence.SuccessInput = false;
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
                    isUndecrease = checkSequence.IsUndecreasing(sequence);
                    Console.WriteLine(isUndecrease ? POSITIVEMESSAGE : NEGATIVEMESSAGE);
                }
                catch (System.FormatException ex)
                {
                    Console.WriteLine("ERROR " + ex.Message);
                    enterSequence.SuccessInput = false;
                }
                catch (System.OverflowException ex)
                {
                    Console.WriteLine("ERROR " + ex.Message);
                    enterSequence.SuccessInput = false;
                }
            }
            Console.WriteLine("Press any key for exit");
            Console.ReadKey();
        }
    }
}