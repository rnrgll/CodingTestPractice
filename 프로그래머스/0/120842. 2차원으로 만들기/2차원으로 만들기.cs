using System;

public class Solution {
    public int[,] solution(int[] num_list, int n) {
        int[,] answer = new int[num_list.Length/n,n];
        
        for(int i=0; i<num_list.Length; i+=n){
            for(int j=i; j<i+n; j++){
                answer[i/n,j%n] = num_list[j];
            }
        }
        return answer;
    }
}