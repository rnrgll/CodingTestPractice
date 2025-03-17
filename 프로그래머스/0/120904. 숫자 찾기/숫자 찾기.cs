using System;

public class Solution {
    public int solution(int num, int k) {
        int answer = 0;
        
        string strNum = num.ToString();
        char charK = (char)('0'+k);
        
        for(int i=0; i<strNum.Length; i++){
            if(strNum[i]==charK){
                answer = i+1;
                return answer;
            }
        }
        
        answer = -1;
        return answer;
    }
}