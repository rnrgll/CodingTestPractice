using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        
        List<int> minusVals = new List<int>();
        List<int> plusVals = new List<int>();
        
        for(int i=0; i<numbers.Length; i++){
            if(numbers[i]<0) minusVals.Add(numbers[i]);
            else plusVals.Add(numbers[i]);
        }
        
        minusVals.Sort();
        plusVals.Sort();
        
        int maxVal1 = int.MinValue;
        int maxVal2 = maxVal1;
        
        if(minusVals.Count==1 && plusVals.Count==1) answer = minusVals[0] * plusVals[0];
        else{
            if(minusVals.Count > 1) maxVal1 = minusVals[0] * minusVals[1];
            if(plusVals.Count>1) maxVal2 = plusVals[plusVals.Count-1] * plusVals[plusVals.Count-2];
            answer = Math.Max(maxVal1, maxVal2);
        }
        
        return answer;
        
    }
}