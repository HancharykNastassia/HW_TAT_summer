﻿using System;

namespace Sequence
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            CheckSequence enterSequense = new CheckSequence();
            int[] sequence;
            bool isUndecrease = true;
            do
            {
                sequence = enterSequense.EnterSequense();
                isUndecrease = enterSequense.IsUndecreasing(sequence);
            }
            while (sequence == null);
            string positiveMessage = "The sequence is undecreasing";
            string negativeMessage = "The sequence is not undecreasing";
            Console.WriteLine(isUndecrease ? positiveMessage : negativeMessage);
            Console.WriteLine("Press any key for exit");
            Console.ReadKey();
        }
    }
}