namespace LeetcodeTasks.RemoveElement
{
    public class RemoveElement
    {
        private readonly int[] _array;
        private readonly int _value;

        public RemoveElement(int[] array, int value)
        {
            _array = array;
            _value = value;
        }

        public int SolutionOne()
        {
            if (_array == null || _array.Length == 0)
            {
                return 0;
            }
            
            if (_array.Length == 1 && _array[0] == _value)
            {
                return 0;
            }
            else if (_array.Length == 1 && _array[0] != _value)
            {
                return 1;
            }
            
            int i = 0;
            int n = _array.Length;
            while (i < n) 
            {
                if (_array[i] == _value) 
                {
                    _array[i] = _array[n - 1];
                    n--;
                } 
                else 
                {
                    i++;
                }
            }
            return n;
        }

        public int SolutionTwo()
        {
            int i = 0;
            for (int j = 0; j < _array.Length; j++) {
                if (_array[j] != _value) {
                    _array[i] = _array[j];
                    i++;
                }
            }
            return i;
        }
        
        
    }
}