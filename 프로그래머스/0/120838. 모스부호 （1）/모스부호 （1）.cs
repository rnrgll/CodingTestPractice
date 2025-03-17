using System;

public class Solution {
    string[] morse = {".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
    public string solution(string letter) {
        string answer="";
        string[] morseArray = letter.Split(' '); //string 배열을 반환
        
        foreach(string m in morseArray){
            int idx = 0;
            for(; idx<morse.Length; idx++){
                if(string.Equals(morse[idx], m)) break;
            }
            answer += ((char)('a' + idx)).ToString();
            
        }
        return answer;
    }
}