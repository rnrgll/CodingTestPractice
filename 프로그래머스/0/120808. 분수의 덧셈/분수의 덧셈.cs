using System;

public class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
        int[] answer = new int[2];
        
        //최대 공약수 찾기
        int gcd = FindGCD(denom1, denom2);
        
        int denom = (denom1/gcd) * denom2;
        int numer = numer1 * (denom2/gcd) + numer2 * (denom1/gcd);
        
        
        int gcd2 = FindGCD(denom, numer);
        answer[0] = numer / gcd2;
        answer[1] = denom / gcd2;
        
        
        return answer;
    }
    
    
    public int FindGCD(int n1, int n2){
        int minVal = Math.Min(n1, n2);
        int maxVal = Math.Max(n1, n2);

        int gcd = 1;
        for(int i=1; i<=minVal; i++){
            if(minVal%i ==0 && maxVal%i==0){
                gcd = (gcd<i)? i: gcd;
            }
        }
        return gcd;
    }
 }
    



    
   

