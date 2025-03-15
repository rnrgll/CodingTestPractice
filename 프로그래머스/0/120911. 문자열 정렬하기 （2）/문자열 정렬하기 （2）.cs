using System;

public class Solution {
    public string solution(string my_string) {
        
        my_string = my_string.ToLower();
        char[] charArray = my_string.ToCharArray();
        Array.Sort(charArray);
        
        string answer = new string(charArray);
        
        return answer;
    }
}