namespace LeetcodeTasks.TwoSum2
{
    public class Solution
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            var twoSum = new TwoSum2(numbers,target);
            return twoSum.GetTwoSum();
        }
    }
}