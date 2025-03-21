using System;

public class Solution {
    public int[] solution(int n) {
        int[] answer = new int[10000];
        int idx = 0;
        for(int i=2, divNum = n; divNum!=1 && i<n; i++){
            if(divNum%i==0 && isPrime(i))
            {
                answer[idx++] = i;
                while(divNum%i!=0) divNum/=i;
            }

        }
        
        //n이 소수면 자기 자신만 답
        if(answer[0]==0){
            answer[idx++] = n;
        }
        
        int[] result = new int[idx];
        for(int i=0; i<idx; i++){
            result[i] = answer[i];
        }
        
        return result;
    }
    
    public bool isPrime(int n){
        for(int i=2; i<n; i++){
            if(n%i==0) return false;
        }
        return true;
    }
}