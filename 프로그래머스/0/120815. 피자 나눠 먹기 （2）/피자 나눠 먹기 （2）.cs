using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        //n명이 모두 같은 수의 피자를 남기지 않고.....
        //6이랑 n의 최소공배수를 구하기
        //최대 공약수 구하기
        int gcd = FindGCD(n, 6);
        // Console.WriteLine(gcd);
        int lcd = n * 6 / gcd;
        answer = lcd / 6;
        
        return answer;
    }
    
    public int FindGCD(int n1, int n2){
        int gcd = 1;
        int minVal = Math.Min(n1, n2);
        int maxVal = Math.Max(n1, n2);
        for(int i=2; i<=minVal; i++){
            if(maxVal%i==0 && minVal%i==0)
                gcd = i;
        }
        
        return gcd;
    }
}