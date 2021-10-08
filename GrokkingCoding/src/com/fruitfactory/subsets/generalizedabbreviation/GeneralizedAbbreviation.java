package com.fruitfactory.subsets.generalizedabbreviation;

import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;
import java.util.Queue;

public class GeneralizedAbbreviation {


    class AbbreviationWord {
        StringBuilder str;
        int start;
        int count;

        public AbbreviationWord(StringBuilder str, int start, int count) {
            this.str = str;
            this.start = start;
            this.count = count;
        }
    }


    private String _word;

    public GeneralizedAbbreviation(String _word) {
        this._word = _word;
    }

    public List<String> generateGeneralizedAbbreviation(){

        if(_word == null || _word.length() == 0){
            return null;
        }

        int wordLen = _word.length();

        List<String> result = new ArrayList<>();
        Queue<AbbreviationWord> q = new LinkedList<>();
        q.add(new AbbreviationWord(new StringBuilder(),0,0));

        while(!q.isEmpty()){
            AbbreviationWord aw = q.poll();

            if(aw.start == wordLen){
                if(aw.count != 0){
                    aw.str.append(aw.count);
                }
                result.add(aw.str.toString());
            }else {
                q.add(new AbbreviationWord(new StringBuilder(aw.str), aw.start + 1, aw.count + 1));
                if(aw.count != 0)
                    aw.str.append(aw.count);
                q.add(new AbbreviationWord(new StringBuilder(aw.str).append(_word.charAt(aw.start)), aw.start + 1, 0));
            }

        }

        return result;
    }

}
