using System;

public class Solution {
    public int solution(int[] array) {
        int[] cnt = new int[1000];
        int maxIdx=0;
        int maxValue=-1;
        int maxCnt=0;
        
        for(int i=0; i<array.Length; i++){
            cnt[array[i]]++;
        }
        
        for(int i=0; i<cnt.Length; i++){
            if(cnt[i]>maxValue){
                maxValue = cnt[i];
                maxCnt = 1;
                maxIdx = i;
            }
            else if(cnt[i]==maxValue){
                maxCnt++;
            }
        }
        
        int answer = 0;
        if(maxCnt>1) answer = -1;
        else answer = maxIdx;
        return answer;
    }
}