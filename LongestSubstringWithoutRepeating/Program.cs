using System;
using System.Collections.Generic;
using System.Xml.XPath;

namespace LongestSubstringWithoutRepeating
{
	class Program
	{
		static void Main ( string[] args )
		{
			var input = new Dictionary<string,int>()
			{
				{"abcabcbb",3},
				{"bbbbbbbb",1 },
				{"pwwkew", 3 },
				{"",0 },
				{" ",1 },
				{"au",2 },
				{"dvdf",3}
			};

			foreach (var pair in input)
			{
				var result = CheckTheLongestSubstring(pair.Key);
				Console.WriteLine($"{pair.Key}({pair.Value}): {result}");
			}

			Console.WriteLine("Press ENTER to exit...");
			Console.ReadLine();

		}

		static int CheckTheLongestSubstring ( string s)
		{
			if(string.IsNullOrEmpty(s))
			{
				return 0;
			}

			if(s.Length == 1)
			{
				return 1;
			}

			var acturlResult = -1;
			var j = 0;
			var hash = new Dictionary<char,int>();

			while(j < s.Length)
			{
				var current = s[j];
				if(hash.ContainsKey(current))
				{
					j = hash[current] + 1;
					acturlResult = Math.Max(hash.Count,acturlResult);
					hash.Clear();
				}
				hash.Add(s[j],j);
				j++;
			}
			return hash.Count == 0 ? acturlResult : Math.Max(acturlResult,hash.Count);
		}

	}
}
