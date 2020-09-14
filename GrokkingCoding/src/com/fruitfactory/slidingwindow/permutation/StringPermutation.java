package com.fruitfactory.slidingwindow.permutation;

import java.util.HashMap;
import java.util.Map;


//    Given a string and a pattern, find out if the string contains any permutation of the pattern.
//
//    Permutation is defined as the re-arranging of the characters of the string. For example, “abc” has the following six permutations:
//
//    abc
//            acb
//    bac
//            bca
//    cab
//            cba
//    If a string has ‘n’ distinct characters it will have n!n! permutations.


public class StringPermutation {
    public boolean findPermutation(String str, String pattern) {
        char[] arr = pattern.toCharArray();
        Map<Character,Integer> patternMatch = new HashMap<>();
        for (Character ch : arr)
        {
            patternMatch.put(ch, patternMatch.getOrDefault(ch,0) + 1);
        }

        Integer windowStart = 0, windowEnd = 0, matched = 0;

        for (windowEnd = 0; windowEnd < str.length(); windowEnd++) {
            char rightCh = str.charAt(windowEnd);
            if(patternMatch.containsKey(rightCh)) {
                patternMatch.put(rightCh, patternMatch.get(rightCh) - 1);
                if(patternMatch.get(rightCh) == 0){
                    matched++;
                }
            }

            if(matched == patternMatch.size()) return true;

            if(windowEnd >= pattern.length() - 1){
                char leftCh = str.charAt(windowStart);
                if(patternMatch.containsKey(leftCh)){
                    if(patternMatch.get(leftCh) == 0){
                        matched--;
                    }
                    patternMatch.put(leftCh,patternMatch.getOrDefault(leftCh,0) + 1);
                }
            }
        }

        return false;

    }
}
