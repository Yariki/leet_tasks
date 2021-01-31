package com.fruitfactory.twoheaps.maximizecapital;

import java.util.PriorityQueue;

public class MaximazeCapital {

    private int[] capital;
    private int[] profits;
    private int numberOfProjects;
    private int initialCapital;

    public MaximazeCapital(int[] capital, int[] profits, int numberOfProjects, int initialCapital) {
        this.capital = capital;
        this.profits = profits;
        this.numberOfProjects = numberOfProjects;
        this.initialCapital = initialCapital;
    }

    public int findMaxCapital(){
        if(capital == null || profits == null || capital.length == 0 || profits.length == 0)
            return Integer.MIN_VALUE;
        int n = profits.length;

        PriorityQueue<Integer> minCapitalHeap = new PriorityQueue<>(n, (i1,i2) -> capital[i1] - capital[i2]);
        PriorityQueue<Integer> maxProfitHeap = new PriorityQueue<>(n, (i1, i2) -> profits[i2] - profits[i1]);

        for (int i = 0; i < n; i++) {
            minCapitalHeap.offer(i);
        }
        int aviableCapital = initialCapital;

        for (int i = 0; i < numberOfProjects; i++) {

            while (!minCapitalHeap.isEmpty() && capital[minCapitalHeap.peek()] <= aviableCapital)
                maxProfitHeap.offer(minCapitalHeap.poll());

            if(maxProfitHeap.isEmpty())
                break;

            aviableCapital += profits[maxProfitHeap.poll()];
        }

        return aviableCapital;
    }


}
