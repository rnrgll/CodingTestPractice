using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        int i = 1;
        while(Factorial(i)*(i+1)<=n){
            i++;
        }
        answer = i;
        return answer;
    }
    
    
    public int Factorial(int n){
        if(n==1) return 1;
        else return n*Factorial(n-1);
    }
}