#include <string>
#include <vector>
#include <iostream>

using namespace std;

int solution(int num) {
    int answer = 0;
    if(num==1) return 0;
    
    long long value = num;
    while(answer<500 && value !=1){
        if(value%2==0)
            value/=2;
        else
            value = value*3+1;
        
        answer++;
    }
    
    if(value!=1) answer=-1;
    return answer;
}