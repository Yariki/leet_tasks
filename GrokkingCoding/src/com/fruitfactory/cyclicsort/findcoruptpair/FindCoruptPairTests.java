package com.fruitfactory.cyclicsort.findcoruptpair;

import com.fruitfactory.cyclicsort.ArrayExtensions;
import org.junit.Test;
import static org.junit.Assert.*;

import java.util.ArrayList;
import java.util.List;

public class FindCoruptPairTests {

    @Test
    public void FirstTest(){
        int[] arr =new int[]{3, 1, 2, 5, 2};
        FindCoruptPair fcp = new FindCoruptPair();
        int[] result = fcp.findCorruptPair(arr);

        assertArrayEquals(new int[] {2,4}, result);
    }

    @Test
    public void SecondTest(){
        int[] arr =new int[]{3, 1, 2, 3, 6, 4};
        FindCoruptPair fcp = new FindCoruptPair();
        int[] result = fcp.findCorruptPair(arr);

        assertArrayEquals(new int[] {3,5}, result);
    }

}
