using System;

public class Solution {
    public string[] solution(string my_str, int n) {
        int size = (int)(Math.Ceiling(my_str.Length/(double)n));
        string[] answer = new string[size];
        
        for(int i=0; i<my_str.Length; i+=n){
            int subLen = n;
            if(i+subLen >= my_str.Length){
                subLen = my_str.Length - i;
            }
            answer[i/n] = my_str.Substring(i,subLen);
        }
        
        return answer;
    }
}