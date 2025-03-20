using System;

public class Solution {
    public int[] solution(int[] emergency) {
        //1~100 인덱스 = 응급도
        // 값 = 진료 순서
        
        int[] orderArray = new int[101];
        int order = 1;
        
        for(int i=0; i<emergency.Length; i++, order++){
            orderArray[emergency[i]] = order;
        }
        
        int[] answer = new int[emergency.Length];
        for(int i=1, idx=0; i<orderArray.Length; i++){
            if(orderArray[i]!=0){
                answer[idx++] = order - orderArray[i]; 
            }
        }
        
        return answer;

    }
}