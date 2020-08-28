using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace LeetcodeTasks.ImageSmoother
{
    public class ImageSmoother
    {

        private int[][] _arr;

        private IList<(int row,int col)> _indexTemplate = new List<(int row, int col)>()
        {
            (-1,-1),(-1,0),(-1,1),
            (0,-1),(0,0),(0,1),
            (1,-1),(1,0),(1,1)
        };

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


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    temp[i][j] = GetSmootherValue(i, j, rows, cols);
                }
            }

            return temp;
        }

        private int GetSmootherValue(int row, int col, int rows, int cols)
        {
            var value = 0;
            var pixels = 0;

            foreach (var validIndex in GetValidIndexes(row,col,rows,cols))
            {
                var pixelValue = _arr[validIndex.row][validIndex.col];
                if (pixelValue > 0)
                {
                    value += pixelValue;
                }
                pixels++;
            }

            return (int)Math.Floor((float)value / (float)pixels);

        }

        private IEnumerable<(int row, int col)> GetValidIndexes(int currentRow, int currentColumn, int rows, int cols)
        {
            foreach (var valueTuple in _indexTemplate)
            {
                int tRow = currentRow + valueTuple.row;
                int tCol = currentColumn + valueTuple.col;
                if(tRow < 0 || tCol < 0 || tRow >= rows || tCol >= cols ) continue;

                yield return (tRow, tCol);
            }
        }





    }
}