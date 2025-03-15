using System;


public class Solution {
    public int[] solution(int n) {
        int[] answer = new int[10000];
        
        int cnt = 0;
        for(int i=1; i<=n; i++){
            if(n%i==0) {
                answer[cnt++] = i;
            }
        }
        
        int[] result = new int[cnt];
        for(int i=0; i<cnt; i++){
            result[i] = answer[i];
        }
        
        return result;
        
        
    }
}