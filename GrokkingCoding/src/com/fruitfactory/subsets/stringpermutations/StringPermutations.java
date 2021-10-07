package com.fruitfactory.subsets.stringpermutations;

import java.util.ArrayList;
import java.util.List;

public class StringPermutations {

    private String _str;

    public StringPermutations(String _str) {
        this._str = _str;
    }

    public List<String> findLetterCaseStringPermutations(){
        if(_str == null || _str.length() == 0){
            return null;
        }

        List<String> result = new ArrayList<>();
        result.add(_str);

        for (int i = 0; i < _str.length(); i++) {
            if(!Character.isLetter(_str.charAt(i))){
                continue;
            }

            int n = result.size();

            for (int j = 0; j < n; j++) {
                char[] chs = result.get(j).toCharArray();
                if(Character.isUpperCase(chs[i])){
                    chs[i] = Character.toLowerCase(chs[i]);
                }else{
                    chs[i] = Character.toUpperCase(chs[i]);
                }
                result.add(String.valueOf(chs));
            }

        }
        return result;
    }

}
