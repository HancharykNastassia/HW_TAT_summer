using System;

namespace Sequence
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            var enterSequence = new InputClass();
            var checkSequence = new CheckSequence();
            int[] sequence;
            bool isUndecrease = true;
            const string NOTASEQUENCEMESSAGE = "One number is not a sequence. Please enter a sequence.";
            sequence = enterSequence.EnterSequense();
            while (sequence.Length == 1)
            {
                Console.WriteLine(NOTASEQUENCEMESSAGE);
                sequence = enterSequence.EnterSequense();
            }
            isUndecrease = checkSequence.IsUndecreasing(sequence);
            const string positiveMessage = "The sequence is undecreasing";
            const string negativeMessage = "The sequence is not undecreasing";
            Console.WriteLine(isUndecrease ? positiveMessage : negativeMessage);
            Console.WriteLine("Press any key for exit");
            Console.ReadKey();
        }
    }
}