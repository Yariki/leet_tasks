using System;
using System.Collections.Generic;

namespace LeetcodeTasks.MergeTwoSortedArrays
{
    public class MergeTwoSortedArrays
    {
        private int[] _nums1;
        private int[] _nums2;
        private int _m;
        private int _n;

        public MergeTwoSortedArrays(int[] nums1, int[] nums2, int m, int n)
        {
            _nums1 = nums1;
            _nums2 = nums2;
            _m = m;
            _n = n;
        }

        public int[] MergeTwoArraysWithAdditionalMemory()
        {
            if (_nums1.Length != (_m + _n))
            {
                return default(int[]);
            }

            var list = new List<int>();
            int i = 0, j = 0;
            while (i < _m && j < _n)
            {
                if (_nums1[i] <= _nums2[j])
                {
                    list.Add(_nums1[i]);
                    i++;
                }
                else
                {
                    list.Add(_nums2[j]);
                    j++;
                }
            }

            while (i < _m)
            {
                list.Add(_nums1[i]);
                i++;
            }

            while (j < _n)
            {
                list.Add(_nums2[j]);
                j++;
            }

            list.CopyTo(_nums1);

            return _nums1;
        }

        public int[] MergeTwoArraysWithTwoPointers()
        {
            if (_nums2 == null || _nums2.Length == 0)
            {
                return _nums1;
            }

            if (_nums1 == null || _nums1.Length == 0)
            {
                return default(int[]);
            }

            if (_nums1.Length != (_m + _n))
            {
                return default(int[]);
            }


            var id1 = _m - 1;
            var id2 = _n - 1;
            var id3 = (_m + _n) - 1;

            while (id1 >=0 && id2 >=0)
            {
                if (_nums1[id1] >= _nums2[id2])
                {
                    _nums1[id3] = _nums1[id1];
                    id1--;
                }
                else
                {
                    _nums1[id3] = _nums2[id2];
                    id2--;
                }
                id3--;
            }

            while (id2 >= 0)
            {
                _nums1[id3] = _nums2[id2];
                id3--;
                id2--;
            }

            return _nums1;
        }



    }
}