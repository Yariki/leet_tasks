using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;

namespace LeetcodeTasks.AddBinary
{
    public class AddBinary
    {
        private readonly string _left;
        private readonly string _right;

        public AddBinary(string left, string right)
        {
            _left = left;
            _right = right;
        }

        public string SolutionOne()
        {
            var a = _left.Select(ch => ch == '1'? 1:0).ToArray();
            var b = _right.Select(ch => ch == '1'? 1:0).ToArray();
            
            var stack = new Stack<int>();
            var maxLength = Math.Max(a.Length,b.Length);

            var arr = new int[2,maxLength];
            CopyArray(a, maxLength, arr, 0);
            CopyArray(b,maxLength,arr,1);
            
            var carry = 0;
            for(var i = maxLength - 1; i >= 0; --i)
            {
                var left = arr[0,i];
                var right = arr[1,i];
                var result = left + right + carry;
                carry = result / 2;
                stack.Push(result % 2);
            }

            if(carry > 0){
                stack.Push(1);
            }

            var str = new StringBuilder();
            while (stack.Count > 0)
            {
                str.Append(stack.Pop());
            }

            return str.ToString();
        }

        private static void CopyArray(int[] a, int maxLength, int[,] arr, int destRow)
        {
            if (a.Length < maxLength)
            {
                var shift = maxLength - a.Length;
                Buffer.BlockCopy(a, 0, arr, (destRow * arr.GetLength(destRow) * sizeof(int)) + (shift * sizeof(int)),
                    a.Length * sizeof(int));
            }
            else
            {
                Buffer.BlockCopy(a, 0, arr, (destRow * arr.GetLength(destRow) * sizeof(int)), a.Length * sizeof(int));
            }
        }
    }
}