using System;
using System.Collections.Generic;

namespace LeetcodeTasks.ConrainsDuplicates
{
    public class ContainDuplicates
    {
        private int[] _numbers;

        public ContainDuplicates(int[] numbers)
        {
            _numbers = numbers;
        }

        public bool GetContainDuplicatesWithHash()
        {
            if (_numbers == null || _numbers.Length == 0 || _numbers.Length == 1) return false;

            if (_numbers.Length == 2) return _numbers[0] == _numbers[1];
            
            var hash = new HashSet<int>();

            for (int i = 0; i < _numbers.Length; i++)
            {
                if (hash.Contains(_numbers[i]))
                {
                    return true;
                }

                hash.Add(_numbers[i]);
            }

            return false;
        }
        
        
        public bool GetContainDuplicatesWithSorting()
        {
            if (_numbers == null || _numbers.Length == 0 || _numbers.Length == 1) return false;

            if (_numbers.Length == 2) return _numbers[0] == _numbers[1];
            
            Array.Sort(_numbers);

            for (int i = 0; i < _numbers.Length - 1; i++)
            {
                if (_numbers[i] == _numbers[i + 1])
                {
                    return true;
                }
            }
            return false;
        }
        
        
    }
}