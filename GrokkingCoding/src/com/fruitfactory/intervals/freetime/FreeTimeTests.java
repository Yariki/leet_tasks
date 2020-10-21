package com.fruitfactory.intervals.freetime;

import org.junit.Test;
import static org.junit.Assert.*;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class FreeTimeTests {

    @Test
    public void FirstTest(){
        List<List<IntervalE>> input = new ArrayList<>();
        input.add(new ArrayList<IntervalE>(Arrays.asList(new IntervalE(1, 3), new IntervalE(5, 6))));
        input.add(new ArrayList<IntervalE>(Arrays.asList(new IntervalE(2, 3), new IntervalE(6, 8))));
        FreeTime ft = new FreeTime();
        List<IntervalE> result =ft.findFreeTime(input);

        assertNotNull(result);
        assertEquals(1,result.size());
        assertEquals(3, result.get(0).start);
        assertEquals(5, result.get(0).end);
    }


    @Test
    public void SecondTest(){
        List<List<IntervalE>> input = new ArrayList<>();
        input.add(new ArrayList<IntervalE>(Arrays.asList(new IntervalE(1, 3), new IntervalE(9, 12))));
        input.add(new ArrayList<IntervalE>(Arrays.asList(new IntervalE(2, 4), new IntervalE(6, 8))));
        FreeTime ft = new FreeTime();
        List<IntervalE> result =ft.findFreeTime(input);

        assertNotNull(result);
        assertEquals(2,result.size());
        assertEquals(4, result.get(0).start);
        assertEquals(6, result.get(0).end);

        assertEquals(8, result.get(1).start);
        assertEquals(9, result.get(1).end);
    }

    @Test
    public void ThirdTest(){
        List<List<IntervalE>> input = new ArrayList<>();
        input.add(new ArrayList<IntervalE>(Arrays.asList(new IntervalE(1, 3), new IntervalE(2, 4))));
        input.add(new ArrayList<IntervalE>(Arrays.asList(new IntervalE(3,5), new IntervalE(7,9))));
        FreeTime ft = new FreeTime();
        List<IntervalE> result =ft.findFreeTime(input);

        assertNotNull(result);
        assertEquals(1,result.size());
        assertEquals(5, result.get(0).start);
        assertEquals(7, result.get(0).end);
    }
}
