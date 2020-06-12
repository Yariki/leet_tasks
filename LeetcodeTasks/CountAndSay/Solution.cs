using System.Text;

namespace LeetcodeTasks.CountAndSay
{
    public class Solution
    {
        public string CountAndSay(int n) 
        {
        
            if(n == 1) return "1";
                
            var str = "1";
            var strBuilder = new StringBuilder();
            for(int j = 1; j < n;j++)
            {
                char prev = str[0];
                int count = 1;
                strBuilder.Clear();
                for (int i = 1; i < str.Length; i++)
                {
                    var cur = str[i];
                    if (prev != cur)
                    {
                        strBuilder.Append($"{count}{prev}");
                        prev = cur;
                        count = 0;
                        count++;
                    }
                    else
                    {
                        prev = cur;
                        count++;
                    }
                }
                strBuilder.Append($"{count}{prev}");
                str = strBuilder.ToString();
            }
            return str;
        }
    }
}