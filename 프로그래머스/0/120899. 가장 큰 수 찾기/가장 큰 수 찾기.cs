using System;

public class Solution {
    public int[] solution(int[] array) {
        int[] answer = new int[2];
        
        int len = array.Length;
        int maxVal = int.MinValue;
        int idx = -1;
        for(int i=0; i<len; i++){
            if(maxVal<array[i]){
                maxVal = array[i];
                idx = i;
            }
        }
        
        answer[0] = maxVal;
        answer[1] = idx;
        
        return answer;
    }
}