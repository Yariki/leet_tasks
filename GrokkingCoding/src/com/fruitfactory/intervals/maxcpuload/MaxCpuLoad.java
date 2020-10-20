package com.fruitfactory.intervals.maxcpuload;

import java.util.Collections;
import java.util.List;
import java.util.PriorityQueue;

class Job{
    int start;
    int end;
    int cpuload;

    public Job(int start, int end, int cpuload) {
        this.start = start;
        this.end = end;
        this.cpuload = cpuload;
    }
}

public class MaxCpuLoad {

    public int findMaxCpuLoad(List<Job> jobs){
        Collections.sort(jobs, (a,b) -> Integer.compare(a.start,b.start));

        int maxCpuLoad = 0;
        int currentCpuLoad = 0;
        PriorityQueue<Job> minHeap = new PriorityQueue<>(jobs.size(), (a,b) -> Integer.compare(a.end, b.end));

        for (Job job : jobs){
            while(!minHeap.isEmpty() && job.start > minHeap.peek().end)
                currentCpuLoad -= minHeap.poll().cpuload;
            minHeap.offer(job);
            currentCpuLoad += job.cpuload;
            maxCpuLoad = Math.max(maxCpuLoad,currentCpuLoad);
        }
        return maxCpuLoad;
    }

}
