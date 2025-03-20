using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        
        string strNum = "";
        for(int i=0; i<my_string.Length;i++){
            if(my_string[i]>='0' && my_string[i] <= '9') //char.IsDigit(char c)로 해도 됨 : bool 반환
            {
                //숫자면?
                strNum += my_string[i];
            }
            else{
                if(!string.IsNullOrEmpty(strNum))
                {
                    //숫자로 변환 후 answer에 누적
                    answer += int.Parse(strNum);
                    Console.WriteLine(int.Parse(strNum));
                    // string 초기화
                    strNum="";
                }
    
            }
            
        }

        //마지막이 숫자로 끝나는 경우 반영이 안되는 문제 발생
        if(!string.IsNullOrEmpty(strNum)){
            answer += int.Parse(strNum);
            Console.WriteLine(int.Parse(strNum));
        }
            
        return answer;
    }

}