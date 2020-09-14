package com.fruitfactory.slidingwindow.stringanagram;


import org.junit.jupiter.api.Test;

import java.util.List;

import static org.junit.jupiter.api.Assertions.*;

public class StringAnagramTests {

    @Test
    void FirstTest(){
        StringAnagram perm = new StringAnagram();
        List<Integer> result = perm.findStringAnagrams("ppqp","pq");

        assertEquals(2, result.size());
        assertEquals(1,result.get(0));
        assertEquals(2,result.get(1));
    }

    @Test
    void SecondTest(){
        StringAnagram perm = new StringAnagram();
        List<Integer> result = perm.findStringAnagrams("abbcabc","abc");

        assertEquals(3, result.size());
        assertEquals(2,result.get(0));
        assertEquals(3,result.get(1));
        assertEquals(4,result.get(2));

    }

}
