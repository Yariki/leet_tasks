package com.fruitfactory.smallestrwindow;

import com.fruitfactory.stringanagram.StringAnagram;
import org.junit.jupiter.api.Test;

import java.util.List;

import static org.junit.jupiter.api.Assertions.assertEquals;

public class SmallestWindowContainingSubstringTests {

    @Test
    void FirstTest(){
        SmallestWindowContainingSubstring smallWindows = new SmallestWindowContainingSubstring();
        String result = smallWindows.findSubstring("aabdec","abc");

        assertEquals("abdec", result);
;    }


    @Test
    void SecondTest(){
        SmallestWindowContainingSubstring smallWindows = new SmallestWindowContainingSubstring();
        String result = smallWindows.findSubstring("abdabca","abc");

        assertEquals("abc", result);

    }

    @Test
    void ThirdTest(){
        SmallestWindowContainingSubstring smallWindows = new SmallestWindowContainingSubstring();
        String result = smallWindows.findSubstring("adcad","abc");

        assertEquals("", result);

    }
}
