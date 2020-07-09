namespace LeetcodeTasks.RotateArray
{
    public class Solution
    {
        public void Rotate(int[] nums, int k)
        {
            var rotate = new RotateArray(nums,k);
            rotate.PerformRotationInPlace();
        }
    }
}