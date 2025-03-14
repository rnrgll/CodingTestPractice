using System;

public class Solution {
    public int solution(int hp) {
        //장군 개미 5 병정 3 일 1
        
        int answer = 0;
        int[] attacks = new int[] {5, 3, 1};
        
        foreach(int attack in attacks)
        {
            answer += hp/attack;
            hp %= attack;
        }
        
        
        
        return answer;
    }
}