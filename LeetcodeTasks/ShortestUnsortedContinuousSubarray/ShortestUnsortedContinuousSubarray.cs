using System;

namespace LeetcodeTasks.ShortestUnsortedContinuousSubarray
{
    public class ShortestUnsortedContinuousSubarray
    {
        private readonly int[] _nums;

        public ShortestUnsortedContinuousSubarray(int[] nums)
        {
            _nums = nums;
        }

        public int GetLength()
        {
            int start = 0;
            int end = 0;
            // Edge case
            if (_nums == null || _nums.Length <= 1) {return 0;}
        
            // Step 1: Find the element from the start of the array which is in a non-increasing order
            for (start = 0; start< _nums.Length-1; start++)
            {
                if (_nums[start] > _nums[start+1]) { break; }
            }
        
            // Array is already sorted
            if (start == _nums.Length-1) {return 0; }
                                 
            // Step 2: Find the element from the end of the array which is in a non-decreasing order
            for (end = _nums.Length-1; end> 0; end--)
            {
                if (_nums[end] < _nums[end-1]) { break; }
            }
                                 
            // Step 3: Now, we need to find the min and max from start to end
            int max = _nums[start];
            int min = _nums[end];
            for (int i = start; i< end; i++)
            {
                if (_nums[i] > max) {max = Math.Max(_nums[i], max);}            
                if (_nums[i] < min) {min = Math.Min(_nums[i], min);}
            }
        
            // Step 4: Now find the element from 0....start-1 which is just greater than minimum
            // i.e. expand the left boundary
            for (int k = 0; k < start; k++)
            {
                if (_nums[k] > min) {start = k; break;}
            }
        
            // Step 4: Now find the element from end+1....n-1 which is just smaller than maximum
            // i.e. expand the right boundary
            for (int j = _nums.Length - 1; j >= end+1; j--)
            {
                if (_nums[j] < max) {end = j; break;}
            }
                               
            // You need to add 1 to the diff of end and start
            return (end - start) +1 ;
        }
    }
}