using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace LeetcodeTasks.StrStr
{
    public class StrStr
    {
        private readonly string _haysstack;
        private readonly string _needle;

        public StrStr(string haysstack, string needle)
        {
            _haysstack = haysstack;
            _needle = needle;
        }


        public int SolutionOne()
        {
            if (string.IsNullOrWhiteSpace(_needle))
                return 0;

            if (string.IsNullOrWhiteSpace(_haysstack))
                return -1;

            int hLength = _haysstack.Length;
            int nLength = _needle.Length;
            int j = 0;

            if (hLength < nLength) return -1;

            for (int i = 0; i <= hLength - nLength; i++)
            {
                for (j = 0; j < nLength; j++)
                {
                    if (_haysstack[i + j] != _needle[j])
                    {
                        break;
                    }
                }

                if (j == nLength)
                {
                    return i;
                }
            }
            return -1;
        }

        public int SolutionKMP()
        {
            if (string.IsNullOrWhiteSpace(_needle))
                return 0;

            if (string.IsNullOrWhiteSpace(_haysstack))
                return -1;

            var M = _needle.Length;

            var dfa = new Dictionary<char, int[]>();

            foreach (var ch in _haysstack)
            {
                if (!dfa.ContainsKey(ch))
                {
                    dfa.Add(ch, new int[M]);
                }
            }

            int X, j;

            for (X = 0, j = 1; j < M; j++)
            {
                foreach (var pair in dfa)
                {
                    dfa[pair.Key][j] = dfa[pair.Key][X];
                }
                char ch = _needle[j];
                dfa[ch][j] = j + 1;
                X = dfa[ch][X];
            }


            int i, N = _haysstack.Length;
            for (i = 0, j =0; i < N && j < M; i++)
            {
                j = dfa[_haysstack[i]][j];
            }

            return j == M ? i - M : N;

        }


    }
}