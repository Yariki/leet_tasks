using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeetcodeTasks.ValidParentheses
{
    public class ValidParentheses
    {
        private string _inputString = string.Empty;
        
        private readonly List<char> Parentheses = new List<char>()
        {
            '(',
            '{',
            '['
        };
        
        private readonly Dictionary<char,char> ParenthesesBack = new Dictionary<char, char>()
        {
            {')','('},
            {'}','{'},
            {']','['},
        };
        
        
        public ValidParentheses(string inputString)
        {
            _inputString = inputString;
        }

        public bool SolutionOne()
        {
            if (string.IsNullOrEmpty(_inputString))
                return true;
            
            if (_inputString.Length == 1)
                return false;
            
            var stack = new Stack<char>();
            foreach (var ch in _inputString)
            {
                
                if(ParenthesesBack.ContainsKey(ch))
                {
                    if (stack.Count == 0) return false;
                    
                    var open = ParenthesesBack[ch];
                    var prev = stack.Pop();
                    if (prev != open)
                        return false;
                } 
                else 
                {
                    stack.Push(ch);
                }
            }
            return stack.Count == 0;
        }
    }
}