using System.Collections;
using System.Collections.Generic;

namespace LeetcodeTasks.PlusOne
{
    public class PlusOne
    {
        private readonly int[] _array;

        public PlusOne(int[] array)
        {
            _array = array;
        }

        public int[] SolutionOne()
        {
            var lastResult = _array[_array.Length - 1] + 1;
            var needtransfer = lastResult > 9;
            var stack = new Stack<int>();
            stack.Push(needtransfer ? 0 : lastResult);

            for (int i = _array.Length - 2; i >= 0; i--)
            {
                if(needtransfer)
                {
                    lastResult = _array[i] + 1;    
                    needtransfer = lastResult > 9;
                    stack.Push(needtransfer ? 0 : lastResult);
                }
                else
                {
                    stack.Push(_array[i]);    
                }
            }
            if(needtransfer) {
                stack.Push(1);
            }

            return stack.ToArray();
        }

        public int[] SolutionTwo()
        {
            var carry = 1;
            var stack = new Stack<int>();

            for (int i = _array.Length - 1; i >= 0; i--)
            {
                var res = _array[i] + carry;
                carry = res > 9 ? 1 : 0;
                stack.Push(res % 10);
            }
            if(carry > 0) stack.Push(1);

            return stack.ToArray();
        }
        
    }
}