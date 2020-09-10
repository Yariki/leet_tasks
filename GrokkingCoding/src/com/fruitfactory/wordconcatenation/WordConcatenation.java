package com.fruitfactory.wordconcatenation;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class WordConcatenation {
    public List<Integer> findWordConcatenation(String str, String[] words) {
        List<Integer> resultIndices = new ArrayList<Integer>();
        int wordLength = words[0].length();
        int patternSize = wordLength * words.length;
        List<int[]> patternMatch = new ArrayList<>();

        for (String word: words){
            int[] arr = new int[wordLength];
            patternMatch.add(arr);
            for (int i = 0; i < word.length(); i++) {
                arr[i] = 1;
            }
        }

        int start = 0, matched = 0;

        for (int end = 0; end < str.length(); end++) {
            char right = str.charAt(end);

            int index = end % wordLength;
            for (int i = 0; i < words.length; i++){
                String word = words[i];
                if(right == word.charAt(index)){
                    patternMatch.get(i)[index] = patternMatch.get(i)[index] - 1;
                    if( patternMatch.get(i)[index] >= 0)
                        matched++;
                }
            }

            if(end - start + 1 == patternSize){
                if(matched == patternSize){
                    resultIndices.add(start);
                }
                int len = start + wordLength;
                for (int i = start; i < len; i++) {
                    char left = str.charAt(i);
                    start++;
                    for (int j = 0; j < words.length; j++){
                        index = i % wordLength;
                        String word = words[j];
                        if(left == word.charAt(index)){
                            if(patternMatch.get(j)[index] >= 0)
                                matched--;
                            patternMatch.get(j)[index] = patternMatch.get(j)[index] + 1;
                        }
                    }
                }
            }
        }

        return resultIndices;
    }

    public List<Integer> findWordConcatenation2(String str, String[] words) {
        Map<String, Integer> wordFrequencyMap = new HashMap<>();
        for (String word : words)
            wordFrequencyMap.put(word, wordFrequencyMap.getOrDefault(word, 0) + 1);

        List<Integer> resultIndices = new ArrayList<Integer>();
        int wordsCount = words.length, wordLength = words[0].length();

        for (int i = 0; i <= str.length() - wordsCount * wordLength; i++) {
            Map<String, Integer> wordsSeen = new HashMap<>();
            for (int j = 0; j < wordsCount; j++) {
                int nextWordIndex = i + j * wordLength;
                // get the next word from the string
                String word = str.substring(nextWordIndex, nextWordIndex + wordLength);
                if (!wordFrequencyMap.containsKey(word)) // break if we don't need this word
                    break;

                wordsSeen.put(word, wordsSeen.getOrDefault(word, 0) + 1); // add the word to the 'wordsSeen' map

                // no need to process further if the word has higher frequency than required
                if (wordsSeen.get(word) > wordFrequencyMap.getOrDefault(word, 0))
                    break;

                if (j + 1 == wordsCount) // store index if we have found all the words
                    resultIndices.add(i);
            }
        }

        return resultIndices;
    }


}
