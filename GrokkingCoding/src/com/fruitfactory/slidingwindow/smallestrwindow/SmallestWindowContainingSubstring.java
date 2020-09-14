package com.fruitfactory.slidingwindow.smallestrwindow;

import java.util.HashMap;
import java.util.Map;

public class SmallestWindowContainingSubstring {

    public String findSubstring(String str, String pattern) {

        if(str.length() < pattern.length()) return "";

        Map<Character, Integer> patterCh = new HashMap<>();
        for (char ch :
                pattern.toCharArray()) {
            patterCh.put(ch,patterCh.getOrDefault(ch,0) + 1);
        }
        int start = 0, matched = 0, minLength = str.length() + 1;
        int subStrStart = 0;

        for (int end = 0; end < str.length(); end++) {
            char right = str.charAt(end);

            if(patterCh.containsKey(right)){
                patterCh.put(right,patterCh.get(right) - 1);
                if(patterCh.get(right) >= 0){
                    matched++;
                }
            }
            while(matched == pattern.length()){
                if(minLength > end - start + 1){
                    minLength = end - start + 1;
                    subStrStart = start;
                }
                char left = str.charAt(start++);
                if(patterCh.containsKey(left)){
                    if(patterCh.get(left) == 0)
                        matched--;
                    patterCh.put(left, patterCh.get(left) + 1);
                }

            }
        }
        return minLength > str.length() ? "" : str.substring(subStrStart, subStrStart + minLength);
    }

}
