using System;

public class Solution {
    public string solution(string rsp) {
        string answer = "";
        foreach(char c in rsp){
            switch(c){
                case '2':
                    answer+="0";
                    break;
                case '0':
                    answer += "5";
                    break;
                case '5':
                    answer += "2";
                    break;
            }
        }

        return answer;
    }
}