#include <iostream>
#include <vector>
using namespace std;
const int INF = 1000000000;
typedef pair<int, int> p;

int calc(int mode, int n1, int n2){
    switch(mode){
        case 0:
            return n1+n2;
        case 1:
            return n1-n2;
        case 2:
            return n1*n2;
        case 3:
            return n1/n2;
    }
}

void backTracking(int value, int n, int idx, int& max_value, int& min_value, const vector<int>& nums, vector<int>& opr){
    //1. 피연산자를 모두 사용했을 경우
    //최솟값, 최댓값 갱신 & 탐색 종료
    if(idx == n){
        max_value = max(max_value, value);
        min_value = min(min_value, value);
        return;
    }
    
    //2. 피연산자를 모두 사용하지 않았을 경우
    for(int i=0; i<4; i++){
        //연산자 확인 -> 연산자가 모두 사용됐을 경우 다음 연산자로 이동
        if(opr[i]==0){
            continue;
        }
        //연산자 1 감소 후 계산
        opr[i]--;
        int next_value = calc(i, value, nums[idx]);
        //다음 피연산자로 넘어감 -> 재귀호출
        //idx++; 인덱스 변수에 저장된 값을 증가시키면 안된다. 백트래킹에 넘겨줄 때만 증가시켜야함
        backTracking(next_value, n, idx+1, max_value, min_value, nums,opr);
        //백트래킹!! 경로 탐색을 종료하고 돌아오는 상황 -> 연산자 수 복구시키기
        opr[i]++;
    }
}


p solution(int n, const vector<int>& nums, vector<int>& opr){
    int max_value = -INF, min_value = INF; 
    backTracking(nums[0], n, 1, max_value, min_value, nums, opr); 
    return {max_value, min_value};
}

int main(){
    int n;
    vector<int> nums(n, 0);
    vector<int> opr(4, 0);
    
    //수 입력
    cin >> n;
    for(int i=0; i<n; i++){
        cin >> nums[i];
    }
    
    
    //연산자 입력
    for(int i=0; i<4; i++){
        cin >> opr[i];
    }
    
    p ans = solution(n, nums, opr);
    cout << ans.first << '\n' << ans.second;
    
    
    return 0;
}