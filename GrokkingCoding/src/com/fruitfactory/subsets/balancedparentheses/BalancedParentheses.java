package com.fruitfactory.subsets.balancedparentheses;


import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;
import java.util.Queue;

public class BalancedParentheses {



    class ParenthesesString{

        String s;
        int open;
        int close;

        public ParenthesesString(String s, int open, int close) {
            this.s = s;
            this.open = open;
            this.close = close;
        }
    }


    private int _num;

    public BalancedParentheses(int _num) {
        this._num = _num;
    }

    public List<String> generateValidParenthesis(){

        if(_num == 0){
            return null;
        }

        List<String> result = new ArrayList<>();
        Queue<ParenthesesString> q = new LinkedList<>();
        q.add(new ParenthesesString("",0,0));
        while(!q.isEmpty()){
            ParenthesesString ps = q.poll();
            if(ps.open == _num && ps.close == _num){
                result.add(ps.s);
            } else {
                if(ps.open < _num){
                    q.add(new ParenthesesString(ps.s + "(",ps.open+1, ps.close));
                }

                if(ps.open > ps.close){
                    q.add(new ParenthesesString(ps.s + ")", ps.open, ps.close + 1));
                }
            }

        }

        return result;
    }

}
