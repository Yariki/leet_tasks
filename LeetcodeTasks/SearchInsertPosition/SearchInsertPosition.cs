namespace LeetcodeTasks.SearchInsertPosition
{
    public class SearchInsertPosition
    {
        private readonly int[] _array;
        private readonly int _value;

        public SearchInsertPosition(int[] array, int value)
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
            
            int l = 0;
            int r = _array.Length - 1;
            int m;
            while (l <= r)
            {
                m = (l + r) / 2;
                if (_array[m] == _value)
                {
                    return m;
                }
                else if( _value > _array[m])
                {
                    l = m + 1;
                }
                else
                {
                    r = m - 1;
                }
            }
            return l;
        }
        
    }
}