using System;

namespace Sequence
{
    class EntryPoint
    {        
        static void Main(string[] args)
        {
            IsSequenceUndecrease enterSequense = new IsSequenceUndecrease();
            int[] sequence;
            do
            {
                sequence = enterSequense.EnterSequense();
            }
            while (sequence == null);
            bool isUndecrease = enterSequense.isUndecreasing(sequence);
            string positiveMessage = "The sequence is undecreasing";
            string negativeMessage = "The sequence is not undecreasing";
            Console.WriteLine(isUndecrease ? positiveMessage : negativeMessage);
            Console.WriteLine("Press any key for exit");
            Console.ReadKey();
        }
    }
}