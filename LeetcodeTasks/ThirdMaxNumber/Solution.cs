namespace LeetcodeTasks.ThirdMaxNumber
{
    public class Solution
    {
        public int ThirdMax(int[] nums)
        {
            var sol = new ThirdMaxNumber(nums);
            return sol.GetThirdMax();
        }
    }
}