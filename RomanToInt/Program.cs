using System;
using System.Collections.Generic;

namespace RomanToInt
{
    
    public class Solution
    {
        IDictionary<char, int> Romans = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
            {'@',0}
        };
	
        public int RomanToIntFirstAttempt(string s)
        {
            if(string.IsNullOrWhiteSpace(s)) return 0;
            s = s.ToUpperInvariant();
		
            var result = 0;
            var q = new Queue<char>();
            foreach (var ch in s)
            {
                q.Enqueue(ch);
            }
            while(q.Count > 0)
            {
                var cur = q.Dequeue();
                var next = q.Count > 0 ? q.Peek() : '@';
                result = Romans[cur] >= Romans[next] ? result + Romans[cur] : result + (Romans[next] - Romans[cur]);
                if(Romans[cur] < Romans[next])
                {
                    q.Dequeue();
                }
            }
		
            return result;
        }
	
        public int RomanToInt(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return 0;
            s = s.ToUpperInvariant();
            var result = 0;
            for (int i = 0; i < s.Length;)
            {
                var cur = s[i];
                var next = (i + 1) <= s.Length - 1 ? s[i + 1] : '@';
                result = Romans[cur] >= Romans[next] ? result + Romans[cur] : result + (Romans[next] - Romans[cur]);			
                i = Romans[cur] < Romans[next] ?  i + 2 : i + 1;
            }
            return result;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().RomanToInt("MCMXCIV") == 1994);
        }
    }
}