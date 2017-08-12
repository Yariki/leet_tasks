using System;
using System.Collections.Generic;
using System.Net.WebSockets;

namespace LeetCode
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var arr = new int[] {3,2,3};
            var target = 6;
            var result = TwoSum(arr, target);
            foreach (var i in result)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
        
        public static int[] TwoSum(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length - 1 ; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if ((nums[i] + nums[j]) == target)
                    {
                        return new int[]{i,j};
                    }
                }
            }
            throw new ArgumentOutOfRangeException();
        }
        
        
        
        
        
    }
}