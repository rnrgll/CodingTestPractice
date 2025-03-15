using System;

public class Solution {
    public int[] solution(string my_string) {
        int[] numList = new int[100];
        
        int len = 0;
        int n;
        foreach(char c in my_string){
            if(c>='0' && c<='9'){
                n = c-'0';
                numList[len++] = n;
            }
        }
        
        int[] answer = new int[len];
        for(int i=0; i<len; i++) answer[i] = numList[i];
        Array.Sort(answer);
        
        return answer;
    }
}