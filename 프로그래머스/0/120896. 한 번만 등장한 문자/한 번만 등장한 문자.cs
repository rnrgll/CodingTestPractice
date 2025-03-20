using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        
        int[] charCnt = new int[26];
        
        foreach(char c in s){
            charCnt[c-'a']++;
        }
        for(int i=0; i<charCnt.Length; i++){
            if(charCnt[i]==1)
                answer+= ((char)('a'+i)).ToString();
        }
        
        return answer;
    }
}