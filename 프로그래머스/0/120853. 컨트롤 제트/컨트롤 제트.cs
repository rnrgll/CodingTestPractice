using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        
        string[] strArr = s.Split(' ');
        int num = 0;
        {
            foreach(string str in strArr){
                if(string.Equals(str, "Z"))
                {
                    answer -= num;
                }
                else {
                    num = int.Parse(str);
                    answer += num;
                    
                }
            }
        }
        
        return answer;
    }
}