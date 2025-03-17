using System;

public class Solution {
    public int solution(int i, int j, int k) {
        int answer = 0;
        for(int n=i; n<=j; n++){
            int currentNum = n;
            while(currentNum!=0){
                if(currentNum%10==k) answer++;
                currentNum/=10;
            }
            
        }
        return answer;
    }
}