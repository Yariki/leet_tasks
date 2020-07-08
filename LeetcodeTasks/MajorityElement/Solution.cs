namespace LeetcodeTasks.MajorityElement
{
    public class Solution
    {
        public int MajorityElement(int[] nums)
        {
            var m = new MajorityElement(nums);
            return m.GetMajorityElement();
        }
    }
}