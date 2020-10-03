package com.fruitfactory.slidingwindow.wordconcatenation;

import org.junit.Test;
import static org.junit.Assert.*;
import java.util.List;

public class WordConcatenationTests {

    @Test
    public void FirstTest(){
        WordConcatenation wc = new WordConcatenation();
        List<Integer> result = wc.findWordConcatenation("catfoxcat", new String[]{"cat", "fox"});

        assertEquals(0,result.get(0).intValue());
        assertEquals(3,result.get(1).intValue());

    }


    @Test
    public void SecondTest(){
        WordConcatenation wc = new WordConcatenation();
        List<Integer> result = wc.findWordConcatenation("catcatfoxfox", new String[]{"cat", "fox"});

        assertEquals(3,result.get(0).intValue());
    }

    @Test
    public void ThirdTest(){
        WordConcatenation wc = new WordConcatenation();
        List<Integer> result = wc.findWordConcatenation2("catfoxcat", new String[]{"cat", "fox"});

        assertEquals(0,result.get(0).intValue());
        assertEquals(3,result.get(1).intValue());
    }


    @Test
    public void FourthTest(){
        WordConcatenation wc = new WordConcatenation();
        List<Integer> result = wc.findWordConcatenation2("catcatfoxfox", new String[]{"cat", "fox"});

        assertEquals(3,result.get(0).intValue());
    }
}
