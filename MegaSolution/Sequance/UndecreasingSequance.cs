using System;

namespace Sequence
{
    class CheckSequence
    {
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