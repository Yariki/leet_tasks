package com.fruitfactory.slidingwindow.stringanagram;

import org.junit.Test;

import java.util.List;

import static org.junit.Assert.*;

public class StringAnagramTests {

    @Test
    void FirstTest(){
        StringAnagram perm = new StringAnagram();
        List<Integer> result = perm.findStringAnagrams("ppqp","pq");

        assertEquals(2, result.size());
        assertEquals(1,result.get(0).intValue());
        assertEquals(2,result.get(1).intValue());
    }

    @Test
    void SecondTest(){
        StringAnagram perm = new StringAnagram();
        List<Integer> result = perm.findStringAnagrams("abbcabc","abc");

        assertEquals(3, result.size());
        assertEquals(2,result.get(0).intValue());
        assertEquals(3,result.get(1).intValue());
        assertEquals(4,result.get(2).intValue());

    }

}
