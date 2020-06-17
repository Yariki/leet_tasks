using System.Collections.Generic;

namespace LeetcodeTasks.ClimbStairs
{
    
    /// <summary>
    /// https://www.youtube.com/watch?v=UyDyc6yV1iQ&feature=youtu.be
    /// </summary>
    public class ClimbStairs
    {
        private readonly int _stairs;
        private Dictionary<int,int> _resultsMap = new Dictionary<int, int>();

        public ClimbStairs(int stairs)
        {
            _stairs = stairs;
        }

        public int SolutionOne()
        {
            return CalculateSteps(_stairs,_resultsMap);
        }

        private int CalculateSteps(int remain, IDictionary<int, int> map)
        {
            if (remain < 0) return 0;
            if (remain == 0) return 1;
            if (map.ContainsKey(remain)) return map[remain];

            map[remain] = CalculateSteps(remain - 1, map) + CalculateSteps(remain - 2, map);

            return map[remain];
        }
        
    }
}