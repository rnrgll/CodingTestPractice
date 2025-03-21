using System;

public class Solution {
    public long solution(string numbers) {
        long answer = 0;
        string str = "";
        string numString = "";
        
        string[] numberList = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
        
        
        foreach(char c in numbers)
        {
            str += c.ToString();
           for(int i=0; i<numberList.Length; i++)
            {
                if(string.Equals(numberList[i], str)){
                    numString += i.ToString();
                    str = "";
                    
                    break;
                }
            }
        }
        
        answer = long.Parse(numString);
        
        return answer;
    }
}