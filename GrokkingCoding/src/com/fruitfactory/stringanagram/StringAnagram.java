package com.fruitfactory.stringanagram;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class StringAnagram {

    public List<Integer> findStringAnagrams(String str, String pattern) {
        List<Integer> resultIndices = new ArrayList<Integer>();

        Map<Character,Integer> patternMap = new HashMap<>();

        for (char ch :
                pattern.toCharArray()) {
            patternMap.put(ch, patternMap.getOrDefault(ch,0) + 1);
        }
        int start = 0, matched = 0;

        for (int end = 0; end < str.length(); end++) {
            char right = str.charAt(end);
            if(patternMap.containsKey(right)){
                patternMap.put(right, patternMap.get(right) - 1);
                if(patternMap.get(right) == 0)
                    matched++;
            }

            if(matched == pattern.length()){
                resultIndices.add(start);
            }

            if(end - start + 1 == pattern.length()){
                char left = str.charAt(start);
                if (patternMap.containsKey(left)){
                    if(patternMap.get(left) == 0){
                        matched--;
                    }
                    patternMap.put(left, patternMap.get(left) + 1);
                }
                start++;
            }
        }

        return resultIndices;
    }
}
