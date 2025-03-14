using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        
        char transChar;
        foreach(char c in my_string){
            if(c >= 'a' && c <= 'z') transChar = (char)('A' + (c - 'a'));
            else transChar = (char)('a' + (c - 'A')) ;
            
            answer += transChar.ToString();
        }
        return answer;
    }
}