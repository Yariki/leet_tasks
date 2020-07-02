namespace LeetcodeTasks.SingleNumber
{
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            var number = new SingleNumber(nums);
            return number.GetSingleNumber();
        }
    }
}