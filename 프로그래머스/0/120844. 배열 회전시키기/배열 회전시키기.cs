using System;

public class Solution {
    public int[] solution(int[] numbers, string direction) {
        int[] answer = new int[numbers.Length];
        
        if(string.Equals(direction, "right")){
            for(int i=0; i<numbers.Length; i++){
                answer[(i+1)%numbers.Length] = numbers[i];
            }
        }
        else{
            for(int i=0; i<numbers.Length; i++){
                answer[(i-1+numbers.Length)%numbers.Length] = numbers[i];
            }
        }
        
        
        return answer;
    }
}