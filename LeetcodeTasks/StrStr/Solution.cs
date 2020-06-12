using System.Diagnostics;

namespace LeetcodeTasks.StrStr
{
    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            var sol = new StrStr(haystack,needle);
            return sol.SolutionOne();
        }
    }
}