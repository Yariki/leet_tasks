package com.fruitfactory.intervals;


import java.util.ArrayList;
import java.util.List;
import java.util.PriorityQueue;

class IntervalE {
    int start;
    int end;

    public IntervalE(int start, int end) {
        this.start = start;
        this.end = end;
    }
}

class EmployeeInterval{
    IntervalE interval;
    int employeeIndex;
    int intervalIndex;

    public EmployeeInterval(IntervalE interval, int employeeIndex, int intervalIndex) {
        this.interval = interval;
        this.employeeIndex = employeeIndex;
        this.intervalIndex = intervalIndex;
    }
}


public class FreeTime {

    public List<IntervalE> findFreeTime(List<List<IntervalE>> schedule){
        List<IntervalE> result = new ArrayList<>();

        PriorityQueue<EmployeeInterval> minHeap = new PriorityQueue<>(
                (a,b) -> Integer.compare(a.interval.start,b.interval.start));
        for (int i = 0; i < schedule.size(); i++) {
            minHeap.offer(new EmployeeInterval(schedule.get(i).get(0),i,0));
        }
        IntervalE previousInterval = minHeap.peek().interval;
        while(!minHeap.isEmpty()){
            EmployeeInterval queueTop = minHeap.poll();
            if(previousInterval.end < queueTop.interval.start){
                result.add(new IntervalE(previousInterval.end, queueTop.interval.start));
                previousInterval= queueTop.interval;
            } else {
                if(previousInterval.end < queueTop.interval.end){
                    previousInterval = queueTop.interval;
                }
            }
            List<IntervalE> employeeSchedule = schedule.get(queueTop.employeeIndex);
            if(employeeSchedule.size() > queueTop.intervalIndex + 1){
                minHeap.offer(new EmployeeInterval(employeeSchedule.get(queueTop.intervalIndex + 1), queueTop.employeeIndex, queueTop.intervalIndex + 1 ));
            }
        }

        return result;
    }

}
