using System;

namespace LeetcodeTasks.MaxSubarray
{
    public class MaxSubarray
    {
        private readonly int[] _array;

        public MaxSubarray(int[] array)
        {
            _array = array;
        }

        //Kadane’s Algorithm
        // local_maximum at index i is the maximum of A[i] and the sum of A[i] and local_maximum at index i-1.
        public int SolutionOne()
        {
            var localMax = 0;
            var max = int.MinValue;

            for (int i = 0; i < _array.Length; i++)
            {
                localMax = Math.Max(_array[i], _array[i] + localMax);
                if (localMax > max)
                {
                    max = localMax;
                }
            }

            return max;
        }
    }
}