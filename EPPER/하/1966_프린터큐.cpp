#include <iostream>
#include <queue>
#include <vector>
#include <algorithm>

using namespace std;

int solution(int m, queue<int>& q, vector<int>& priority){
    int ans = 0; //인쇄되는 문서 개수를 카운트

    //1. 중요도를 기준으로 먼저 정렬
    sort(priority.begin(), priority.end());

    //2. 원하는 문서가 출력될 때까지 반복
    while(true){
        if(q.front()==priority[priority.size()-1]){ //인쇄조건을 만족하여 출력되는 경우
            ans++;
            q.pop();
            priority.pop_back();

            if(m==0){ //원하는 문서가 출력됨
                break;
            }
        }
        else{ //인쇄조건을 만족하지 못하는 경우
            q.push(q.front());
            q.pop();
        }

        //문서 위치 업데이트
        m = m == 0? q.size()-1: m-1; 

    }
    return ans;

}


int main(){

    int testcase;
    int n, m;
    int doc;
    cin >> testcase;

    
    while(testcase--){
        //입력
        cin >> n >> m;
        queue<int> q;
        vector<int> priority(n);

        for(int i=0; i<n; i++){
            cin >> doc;
            q.push(doc);
            priority.push_back(doc);
        }
        //연산
        cout << solution(m, q, priority) << '\n';
    }

    return 0;
}