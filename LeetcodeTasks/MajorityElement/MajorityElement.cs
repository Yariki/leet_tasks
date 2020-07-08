using System.Collections.Generic;
using System.Linq;

namespace LeetcodeTasks.MajorityElement
{
    public class MajorityElement
    {
        private readonly int[] _numbers;

        public MajorityElement(int[] numbers)
        {
            _numbers = numbers;
        }

        public int GetMajorityElement()
        {
            if (_numbers == null || _numbers.Length == 0) return -1;

            var appears = _numbers.Length / 2;
            var dictionary = new Dictionary<int, int>();

            for (int i = 0; i < _numbers.Length; i++)
            {
                if (dictionary.ContainsKey(_numbers[i]))
                {
                    dictionary[_numbers[i]]++;
                }
                else
                {
                    dictionary.Add(_numbers[i], 1);
                }
            }

            int max = 0;
            KeyValuePair<int, int> pair = new KeyValuePair<int, int>(-1,-1);
            foreach (var element in dictionary.Where(p => p.Value > appears))
            {
                if (element.Value > max)
                {
                    max = element.Value;
                    pair = element;
                }
            }

            return pair.Value > -1 ? pair.Key : -1;
        }

    }
}