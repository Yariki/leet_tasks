namespace LeetcodeTasks.ValidParentheses
{
    public class Solution 
    {
        public bool IsValid(string s)
        {
            var validParentheses = new ValidParentheses(s);
            return validParentheses.SolutionOne();
        }
    }
}