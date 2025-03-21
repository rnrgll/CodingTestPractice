using System;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        
        foreach(int n in array){
            answer += CountSeven(n);
        }
        
        return answer;
    }
    
    public int CountSeven(int num){
        int cnt = 0;
        while(num!=0)
        {
            if(num%10 == 7) cnt++;
            
            num/=10;
        }
        
        return cnt;
    }
}