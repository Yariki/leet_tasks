package com.fruitfactory.intervals.maxcpuload;

import org.junit.Test;

import java.util.ArrayList;
import java.util.List;

import static org.junit.Assert.*;

public class MaxCpuLoadTests {

    @Test
    public void FirstTest(){
        List<Job>  jobs = new ArrayList<>(){
            {
                add(new Job(1,4,3));
                add(new Job(2,5,4));
                add(new Job(7,9,6));
            }
        };
        MaxCpuLoad cpuLoad = new MaxCpuLoad();
        int result = cpuLoad.findMaxCpuLoad(jobs);

        assertEquals(7,result);
    }

    @Test
    public void SecondTest(){
        List<Job>  jobs = new ArrayList<>(){
            {
                add(new Job(6,7,10));
                add(new Job(2,4,11));
                add(new Job(8,12,15));
            }
        };
        MaxCpuLoad cpuLoad = new MaxCpuLoad();
        int result = cpuLoad.findMaxCpuLoad(jobs);

        assertEquals(15,result);
    }

    @Test
    public void ThirdTest(){
        List<Job>  jobs = new ArrayList<>(){
            {
                add(new Job(1,4,2));
                add(new Job(2,4,1));
                add(new Job(3,6,5));
            }
        };
        MaxCpuLoad cpuLoad = new MaxCpuLoad();
        int result = cpuLoad.findMaxCpuLoad(jobs);

        assertEquals(8,result);
    }


}
