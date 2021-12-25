package com.fruitfactory.subsets.evaluateexpression;

import java.util.ArrayList;
import java.util.List;

public class EvaluateExpression {


    public EvaluateExpression() {
    }

    public List<Integer>  diffWaysToEvaluateExpression(String input){
        if(input == null)
            return null;

        List<Integer> result = new ArrayList<>();

        if(!input.contains("+") && !input.contains("-") && !input.contains("*"))
        {
            result.add(Integer.parseInt(input));
        } else {
            for (int i = 0; i < input.length(); i++){
                char chr = input.charAt(i);
                if(!Character.isDigit(chr)){
                        List<Integer> leftParts = diffWaysToEvaluateExpression(input.substring(0,i));
                    List<Integer> rightParts = diffWaysToEvaluateExpression(input.substring(i+1));
                    for (int part1: leftParts){
                        for (int part2: rightParts){
                            if(chr == '+'){
                                result.add(part1 + part2);
                            } else if(chr == '-'){
                                result.add(part1 - part2);
                            } else if(chr == '*'){
                                result.add(part1 * part2);
                            }
                        }
                    }
                }
            }
        }
        return result;
    }


}

