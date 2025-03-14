using System;

public class Solution {
    public string solution(string my_string, int num1, int num2){
        char[] charArray = my_string.ToCharArray();
        charArray[num1] = my_string[num2];
        charArray[num2] = my_string[num1];
        
        return new string(charArray);
    }
}