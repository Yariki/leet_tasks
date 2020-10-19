package com.fruitfactory.intervals.minmeetingrooms;

import com.fruitfactory.intervals.Interval;
import org.junit.Test;

import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.List;

import static org.junit.Assert.*;

public class MinimumMeetingsRoomTests {

    @Test
    public void FirstTest(){
        List<Interval> intervals = new ArrayList<>(){
            {
                add(new Interval(1,4));
                add(new Interval(2,5));
                add(new Interval(7,9));
            }
        };

        MinimumMeetingsRoom min = new MinimumMeetingsRoom();
        int result = min.findMinimumMeetingRooms(intervals);

        assertEquals(2,result);

    }

    @Test
    public void SecondTest(){
        List<Interval> intervals = new ArrayList<>(){
            {
                add(new Interval(6,7));
                add(new Interval(2,4));
                add(new Interval(8,12));
            }
        };

        MinimumMeetingsRoom min = new MinimumMeetingsRoom();
        int result = min.findMinimumMeetingRooms(intervals);

        assertEquals(1,result);

    }

    @Test
    public void ThirdTest(){
        List<Interval> intervals = new ArrayList<>(){
            {
                add(new Interval(1,4));
                add(new Interval(2,3));
                add(new Interval(3,6));
            }
        };

        MinimumMeetingsRoom min = new MinimumMeetingsRoom();
        int result = min.findMinimumMeetingRooms(intervals);

        assertEquals(2,result);

    }


    @Test
    public void ForthTest(){
        List<Interval> intervals = new ArrayList<>(){
            {
                add(new Interval(4,5));
                add(new Interval(2,3));
                add(new Interval(2,4));
                add(new Interval(3,5));
            }
        };

        MinimumMeetingsRoom min = new MinimumMeetingsRoom();
        int result = min.findMinimumMeetingRooms(intervals);

        assertEquals(2,result);

    }

    @Test
    public void FirstTest2(){
        List<Interval> intervals = new ArrayList<>(){
            {
                add(new Interval(1,4));
                add(new Interval(2,5));
                add(new Interval(7,9));
            }
        };

        MinimumMeetingsRoom min = new MinimumMeetingsRoom();
        int result = min.findMinimumMeetingRooms2(intervals);

        assertEquals(2,result);

    }

    @Test
    public void SecondTest2(){
        List<Interval> intervals = new ArrayList<>(){
            {
                add(new Interval(6,7));
                add(new Interval(2,4));
                add(new Interval(8,12));
            }
        };

        MinimumMeetingsRoom min = new MinimumMeetingsRoom();
        int result = min.findMinimumMeetingRooms2(intervals);

        assertEquals(1,result);

    }

    @Test
    public void ThirdTest2(){
        List<Interval> intervals = new ArrayList<>(){
            {
                add(new Interval(1,4));
                add(new Interval(2,3));
                add(new Interval(3,6));
            }
        };

        MinimumMeetingsRoom min = new MinimumMeetingsRoom();
        int result = min.findMinimumMeetingRooms2(intervals);

        assertEquals(2,result);

    }


    @Test
    public void ForthTest2(){
        List<Interval> intervals = new ArrayList<>(){
            {
                add(new Interval(4,5));
                add(new Interval(2,3));
                add(new Interval(2,4));
                add(new Interval(3,5));
            }
        };

        MinimumMeetingsRoom min = new MinimumMeetingsRoom();
        int result = min.findMinimumMeetingRooms2(intervals);

        assertEquals(2,result);

    }



}
