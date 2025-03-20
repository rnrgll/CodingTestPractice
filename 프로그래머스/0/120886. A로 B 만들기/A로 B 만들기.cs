using System;

public class Solution {
    public int solution(string before, string after) {
        int[] charCnt = new int[26];
        
        foreach(char c in before){
            charCnt[c-'a']++;
        }
        
        foreach(char c in after){
            charCnt[c-'a']--;
        }
        
        foreach(int cnt in charCnt){
            if(cnt<0 || cnt>0) return 0;
        }
        
        return 1;
        
    }
}