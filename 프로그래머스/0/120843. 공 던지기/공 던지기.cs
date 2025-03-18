using System;

public class Solution {
    public int solution(int[] numbers, int k) {
        int answer = 0; //인덱스로 접근하자
        
        for(int i=1; i<k; i++){
            answer = (answer+2)%numbers.Length;
        }
        
        
        return numbers[answer];
    }
}