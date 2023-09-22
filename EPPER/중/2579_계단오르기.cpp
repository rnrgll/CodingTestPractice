#include <iostream>
#include <vector>
#define max(a, b) a>b?a:b; //Max 함수

using namespace std;

int solution(const vector<int>& stair, int n){
    vector<int> stairSum(n+1, 0); //max 값 저장 (메모제이션 기법)
    //기저값 설정
    stairSum[1] = stair[1];
    stairSum[2] = stair[1]+stair[2];
    
    //바텀 업 방식
    for(int i=3; i<n+1; i++){
        //점화식
        stairSum[i] = max(stairSum[i-3]+stair[i-1]+stair[i], stairSum[i-2]+stair[i]);
    }
    return stairSum[n];
}


int main(){
    int n;
    vector<int> stair;
    //입력
    cin >> n;
    stair.assign(n+1, 0);
    
    for(int i=1; i<n+1; i++){
        cin >> stair[i];
    }
    
    cout << solution(stair, n);
    
    return 0;
}