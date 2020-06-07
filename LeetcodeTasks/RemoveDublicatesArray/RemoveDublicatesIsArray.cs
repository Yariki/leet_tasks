using System;

namespace LeetcodeTasks.RemoveDublicatesArray
{
    public class RemoveDublicatesIsArray
    {
        private int[] _array;
        
        public RemoveDublicatesIsArray(int[] arr)
        {
            _array = arr;
        }

        public int SolutionOne()
        {
            if (_array == null || _array.Length == 0)
            {
                return 0;
            }
            
            if (_array.Length == 1)
            {
                return 1;
            }

            var i = 0;
            var j = 0;
            while (j < _array.Length)
            {
                if (_array[i] != _array[j])
                {
                    i++;
                    _array[i] = _array[j];
                }
                j++;
            }
            return i + 1;
        }
    }
}