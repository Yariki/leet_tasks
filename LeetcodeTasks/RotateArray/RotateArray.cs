using System;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace LeetcodeTasks.RotateArray
{
    public class RotateArray
    {
        private int[] _numbers;
        private int _steps;

        public RotateArray(int[] numbers, int steps)
        {
            _numbers = numbers;
            this._steps = steps;
        }

        public void PerformRotationInPlace()
        {
            if (_numbers == null || _numbers.Length == 0) return;

            _steps %= _numbers.Length;

            int temp, previous;
            for (int i = 0; i < _steps; i++)
            {
                previous = _numbers[_numbers.Length - 1];
                for (int j = 0; j < _numbers.Length; j++)
                {
                    temp = _numbers[j];
                    _numbers[j] = previous;
                    previous = temp;
                }
            }
        }

        public void PerformRotationWithAdditionalSpace()
        {
            if (_numbers == null || _numbers.Length == 0) return;

            if (_numbers.Length == 1) return;

            var temp = new int[_steps];

            Array.Copy(_numbers,_numbers.Length - _steps,temp,0,_steps);

            var sourceIndex = _steps;
            var length = _numbers.Length - _steps;
            Array.Copy(_numbers,0,_numbers,_steps,length);

            Array.Copy(temp,0,_numbers,0,_steps);
        }

        public void PerformRotationWithCyclicRotation()
        {
            if (_numbers == null || _numbers.Length == 0) return;

            if (_numbers.Length == 1) return;

            _steps = _steps % _numbers.Length;

            var count = 0;

            for (int start = 0; count < _numbers.Length; start++)
            {
                int current = start;
                int prev = _numbers[start];
                do
                {
                    int next = (current + _steps) % _numbers.Length;
                    int temp = _numbers[next];
                    _numbers[next] = prev;
                    prev = temp;
                    current = next;
                    count++;
                } while (start != current);
            }
        }



    }
}