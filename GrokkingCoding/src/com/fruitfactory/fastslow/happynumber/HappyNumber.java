package com.fruitfactory.fastslow.happynumber;

public class HappyNumber {

    public boolean find(int num) {
        int slow = num, fast = num;
        do {
            slow = findSquereSum(slow);
            fast = findSquereSum(findSquereSum(fast));
        }while(slow != fast);

        return slow == 1;
    }

    private int findSquereSum(int num){
        int sum = 0, digit;

        while(num > 0){
            digit = num % 10;
            sum += digit * digit;
            num /= 10;
        }
        return sum;
    }


}
