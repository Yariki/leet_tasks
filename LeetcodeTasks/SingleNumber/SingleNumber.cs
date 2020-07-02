using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace LeetcodeTasks.SingleNumber
{
    public class SingleNumber
    {
        private readonly int[] _numbers;

        public SingleNumber(int[] numbers)
        {
            _numbers = numbers;
        }

        public int GetSingleNumber()
        {
            if (_numbers == null || _numbers.Length == 0) return 0;

            var dict = new Dictionary<int,int>();

            for (int i = 0; i < _numbers.Length; i++)
            {
                if (!dict.ContainsKey(_numbers[i]))
                {
                    dict.Add(_numbers[i],1);
                }
                else
                {
                    dict[_numbers[i]]++;
                }
            }

            var num = dict.FirstOrDefault(pair => pair.Value == 1);

            return num.Key;
        }

        public int GetSingleNumber2()
        {
            if (_numbers == null || _numbers.Length == 0) return 0;
            int num = 0;

            foreach (var number in _numbers)
            {
                num ^= number;
            }

            return num;
        }

        public int GetSingleNumber3()
        {
            if (_numbers == null || _numbers.Length == 0) return 0;

            var hash = new HashSet<int>();

            int sumOfSet = 0;
            int sumOfNums = 0;

            foreach (var number in _numbers)
            {
                if (!hash.Contains(number))
                {
                    hash.Add(number);
                    sumOfSet += number;
                }

                sumOfNums += number;
            }

            return (2 * sumOfSet) - sumOfNums;
        }


    }
}