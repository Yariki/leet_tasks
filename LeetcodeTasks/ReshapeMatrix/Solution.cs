namespace LeetcodeTasks.ReshapeMatrix
{
    public class Solution
    {
        public int[][] MatrixReshape(int[][] nums, int r, int c)
        {
            var sol = new ReshapeMatrix(nums,r,c);
            return sol.GetRashapedMatrix();
        }
    }
}