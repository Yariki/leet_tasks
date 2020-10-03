package com.fruitfactory.twopointers.shortestwindowsort;

import org.junit.Test;
import static org.junit.Assert.*;


public class ShortestWindowSortTests {

    @Test
    public void FirstTest(){
        int[] arr = new int[] {1, 2, 5, 3, 7, 10, 9, 12};
        ShortestWindowSort sort = new ShortestWindowSort();
        int result = sort.sort(arr);

        assertEquals(5, result);
    }


    @Test
    public void SecondTest(){
        int[] arr = new int[] {1, 3, 2, 0, -1, 7, 10};
        ShortestWindowSort sort = new ShortestWindowSort();
        int result = sort.sort(arr);

        assertEquals(5, result);
    }

    @Test
    public void ThirdTest(){
        int[] arr = new int[] {1, 2, 3};
        ShortestWindowSort sort = new ShortestWindowSort();
        int result = sort.sort(arr);

        assertEquals(0, result);
    }

    @Test
    public void FourthTest(){
        int[] arr = new int[] {3, 2, 1};
        ShortestWindowSort sort = new ShortestWindowSort();
        int result = sort.sort(arr);

        assertEquals(3, result);
    }

    @Test
    public void FirstTest2(){
        int[] arr = new int[] {1, 2, 5, 3, 7, 10, 9, 12};
        ShortestWindowSort sort = new ShortestWindowSort();
        int result = sort.sort2(arr);

        assertEquals(5, result);
    }


    @Test
    public void SecondTest2(){
        int[] arr = new int[] {1, 3, 2, 0, -1, 7, 10};
        ShortestWindowSort sort = new ShortestWindowSort();
        int result = sort.sort2(arr);

        assertEquals(5, result);
    }

    @Test
    public void ThirdTest2(){
        int[] arr = new int[] {1, 2, 3};
        ShortestWindowSort sort = new ShortestWindowSort();
        int result = sort.sort2(arr);

        assertEquals(0, result);
    }

    @Test
    public void FourthTest2(){
        int[] arr = new int[] {3, 2, 1};
        ShortestWindowSort sort = new ShortestWindowSort();
        int result = sort.sort2(arr);

        assertEquals(3, result);
    }


}
