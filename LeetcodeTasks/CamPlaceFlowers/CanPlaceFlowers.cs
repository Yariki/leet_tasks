using System.Collections.Generic;

namespace LeetcodeTasks.CamPlaceFlowers
{
    public class CanPlaceFlowers
    {
        private int[] _nums;
        private int _n;

        public CanPlaceFlowers(int[] nums, int n)
        {
            _nums = nums;
            _n = n;
        }

        public bool CanFlowersBePlaced()
        {
            if (_n == 0) return true;
            if (_nums == null || _nums.Length == 0) return false;

            var list = new List<int>();
            var possibleEmptyPlace = 0;
            var newWindow = false;
            
            
            for (int i = 0; i < _nums.Length; i++)
            {
                if (_nums[i] == 0)
                {
                    possibleEmptyPlace++;
                }
                else if (_nums[i] == 1)
                {
                    if(possibleEmptyPlace != 1 && possibleEmptyPlace % 2 == 1)
                        list.Add(possibleEmptyPlace);

                    possibleEmptyPlace = 0;
                }
            }

            var possibleCount = 0;

            foreach (var place in list)
            {
                possibleCount = possibleCount + (place / 2);
            }

            return possibleCount == _n;
        }
    }
}