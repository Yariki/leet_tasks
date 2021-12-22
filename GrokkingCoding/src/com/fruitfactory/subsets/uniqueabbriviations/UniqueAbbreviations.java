package com.fruitfactory.subsets.uniqueabbriviations;

import com.fruitfactory.helpers.AbbreviatedWord;

import java.util.*;

public class UniqueAbbreviations {

	private String word;

	public UniqueAbbreviations(String word) {
		this.word = word;
	}

	public List<String> findGeneralizedAbbreviations(){
		if(word == null || word.length() == 0){
			return null;
		}

		int wordLen  = word.length();

		Queue<AbbreviatedWord> queue = new LinkedList<>();
		List<String> result = new ArrayList<>();
		queue.add(new AbbreviatedWord(new StringBuilder(),0,0));

		while(!queue.isEmpty()){
			AbbreviatedWord aWord = queue.poll();
			if(aWord.start == wordLen){
				if(aWord.count != 0)
					aWord.str.append(aWord.count);
				result.add(aWord.str.toString());
			} else{
				queue.add(new AbbreviatedWord(new StringBuilder(aWord.str),aWord.start + 1, aWord.count + 1));
				if(aWord.count != 0)
					aWord.str.append(aWord.count);
				queue.add(new AbbreviatedWord(new StringBuilder(aWord.str).append(word.charAt(aWord.start)), aWord.start + 1, 0));
			}
		}

		return result;
	}
}
