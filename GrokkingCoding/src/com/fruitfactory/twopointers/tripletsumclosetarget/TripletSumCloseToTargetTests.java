package com.fruitfactory.twopointers.tripletsumclosetarget;

import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;

public class TripletSumCloseToTargetTests {

    @Test
    public void FirstTest(){
        int[] arr = new int[] {-2, 0, 1, 2};
        int targetSum = 2;
        TripletSumCloseToTarget closeToTarget = new TripletSumCloseToTarget();
        int result = closeToTarget.searchTriplet(arr,targetSum);

        assertEquals(1, result);
    }

    @Test
    public void SecondTest(){
        int[] arr = new int[] {-3, -1, 1, 2};
        int targetSum = 1;
        TripletSumCloseToTarget closeToTarget = new TripletSumCloseToTarget();
        int result = closeToTarget.searchTriplet(arr,targetSum);

        assertEquals(0, result);
    }

    @Test
    public void ThirdTest(){
        int[] arr = new int[] {1, 0, 1, 1 };
        int targetSum = 100;
        TripletSumCloseToTarget closeToTarget = new TripletSumCloseToTarget();
        int result = closeToTarget.searchTriplet(arr,targetSum);

        assertEquals(3, result);
    }
}
