using System;

public class Solution {
    public int solution(int[] sides) {
        int answer = 0;
        int smallSide = Math.Min(sides[0], sides[1]);
        int largeSide = Math.Min(sides[0], sides[1]);
        
        //1. 구하고자 하는 변이 가장 긴 변일 때
        //a, b이고, a<=b라 할 때
        // 가장 긴 변의 길이는
        // b+1이상 (b+a-1)이하 까지 가능
        //즉, (b+a-1) - (b+1) -1 개 = a-1개
        
       
        
        answer += smallSide-1;
        
        //2. 주어진 원소 중에 가장 긴 변이 있는 경우
        //a,b 이고, a<=b일 때,
        //나머지 한 변(x)은 a+x > b이고, x<b이어야 한다.
        //즉, b-a+1 이상 b-1 이하 가능
        
        for(int i=largeSide-smallSide+1; i<=largeSide-1; i++)
            answer++;
        
        //3. 주어진 원소 중 가장 긴 변과 구하고자 하는 변의 길이가 동일
        //a, b (a<b)
        //b=x & b+a>x
        //항상 true이므로 answer 1 증가
        answer++;
        return answer;
    }
}