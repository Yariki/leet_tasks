namespace LeetcodeTasks.SearchInsertPosition
{
    public class Solution
    {
         public int SearchInsert(int[] nums, int target) 
         {
            var sol = new SearchInsertPosition(nums, target);
            return sol.SolutionOne();
         }
    }
}