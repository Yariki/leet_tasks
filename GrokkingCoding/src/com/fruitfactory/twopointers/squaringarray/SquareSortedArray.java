package com.fruitfactory.twopointers.squaringarray;

public class SquareSortedArray {
    public int[] makeSquares(int[] arr) {
        int[] squares = new int[arr.length];

        int highSquare = arr.length - 1;
        int start  = 0, end = arr.length - 1;

        while(start <= end){
            int lSqure = arr[start] * arr[start];
            int rSquare = arr[end] * arr[end];

            if(lSqure > rSquare) {
                squares[highSquare--] = lSqure;
                start++;
            } else{
                squares[highSquare--] = rSquare;
                end--;
            }
        }

        return squares;
    }

}
