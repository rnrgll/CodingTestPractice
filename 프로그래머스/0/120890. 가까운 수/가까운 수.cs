using System;

public class Solution {
    public int solution(int[] array, int n) {
        int closeNum = 0;
        int minOffset = 100;
        foreach(int a in array){
            int offset = Math.Abs(a-n);
            if(minOffset>offset){
                closeNum = a;
                minOffset = offset;
            }
            else if(minOffset == offset){
                if(closeNum>a) closeNum = a;
            }
        }
        
        return closeNum;
    }
}