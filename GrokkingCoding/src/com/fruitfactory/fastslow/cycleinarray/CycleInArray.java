package com.fruitfactory.fastslow.cycleinarray;

public class CycleInArray {


    public boolean loopExist(int[] arr){
        for (int i = 0; i < arr.length; i++) {
            boolean isForward = arr[i] >= 0;
            int slow = i, fast = i;

            do{
                slow = findBNextIndex(arr,isForward,slow);
                fast = findBNextIndex(arr, isForward, fast);
                if(fast != -1){
                    fast = findBNextIndex(arr,isForward,fast);
                }
            }while(slow != -1 && fast != -1 && slow != fast);
            if(slow != -1 && slow == fast){
                return true;
            }
        }
        return false;
    }

    private int findBNextIndex(int[] arr, boolean isForward, int currentIndex){
        boolean  direction = arr[currentIndex] >= 0;
        if(isForward != direction){
            return -1;
        }

        int nextIndex = (currentIndex + arr[currentIndex]) % arr.length;
        if(nextIndex < 0){
            nextIndex += arr.length;
        }
        if(nextIndex == currentIndex){
            nextIndex = -1;
        }
        return nextIndex;
    }

}
