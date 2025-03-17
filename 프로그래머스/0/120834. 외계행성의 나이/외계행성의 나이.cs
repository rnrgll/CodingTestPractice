using System;

public class Solution {
    public string solution(int age) {
        string answer = "";
        
        
        while(age!=0){
            char c = (char)('a' + age%10);
            answer += c.ToString();
            age /= 10;
        }
        char[] charArray = answer.ToCharArray();
        Array.Reverse(charArray);
        answer = new string(charArray);
        return answer;
    }
}