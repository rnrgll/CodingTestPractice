using System;

public class Solution {
    public string solution(string my_string) {
        string answer = ""; //알파벳 26개 0~25차이
        int[] charCnt = new int[53];
        char[] shortChar = new char[110];
        int length = 0;
        
        
        foreach(char c in my_string){
            int offset;
            if(c == ' '){
                offset = 52;
            }
            else{
                offset = c - 'A';
                if(offset>25){
                    offset = c - 'a' + 26;    
                }
            }
            
            if(charCnt[offset]>0) continue;
            charCnt[offset]++;
            shortChar[length++] = c;
            
        }
        
        answer = new string(shortChar); 
        //substring
        answer = answer.Substring(0, length);
            
        
        return answer;
    }
}