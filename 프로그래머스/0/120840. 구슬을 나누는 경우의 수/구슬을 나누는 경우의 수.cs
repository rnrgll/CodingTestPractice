using System;

public class Solution {
    public int solution(int balls, int share) {
        //nCr = n*(n-1)*...*(n-r+1) / r!

        return Combination(balls, share);
    }
    
    public int Combination(int n, int r){
        //시간초과 문제 발생하므로 분자, 분모 같은 반복문에서 계산하자
        //재귀 쓰지 말자
        //overflow 문제 발생.... -> long 형으로 고쳐서 연산하자 (x)
        //오버플로우가 안나오게 계산하는 부분 로직을 수정하자 -> 굳이 분모 분자를 개별로 구하고 나누지 말고 반복문 안에서 한번에 연산해버리자
        
        if(n==r) return 1; // nCn = 1
        if(r>n-r) r = n-r; // //ncr = nC(n-r)
        
        // long m = 1;
        // long c = 1;
        long result = 1;
        for(int i=1;i<=r; i++){
            result = result * (n-i+1) / i; // n, n-1, n-2... n-r+1 까지 곱하기, r!로 나누기
            //오버플로우 발생하니까 나누기를 먼저? -> 아니야 그러면 소수점이 날라가서 문제가 생겨요........
            //그냥 result를 long형으로 놓고 마지막에 int로 반환하기
        }

        return (int)result;
    }
}