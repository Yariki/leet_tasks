using System.Runtime.InteropServices;

namespace LeetcodeTasks.ImageSmoother
{
    public class ImageSmoother
    {

        private int[][] _arr;

        public ImageSmoother(int[][] arr)
        {
            _arr = arr;
        }

        public int[][] ProcessImageSmoother()
        {

            if (_arr == null) return null;
            if (_arr.Length == 0) return null;
            int rows = _arr.GetLength(0);
            int cols = _arr[0].Length;

            var temp = new int[rows][];
            for (int i = 0; i < temp.GetLength(0); i++)
            {
                temp[i] = new int[cols];
            }






            return default(int[][]);
        }
    }
}