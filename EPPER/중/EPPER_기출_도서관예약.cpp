//프로그래머스에서는 main함수 및 입출력문이 필요하지 않습니다. 대신 solution함수만 작성하면 됩니다.
#include <iostream>
#include <vector>

using namespace std;

void sort(int n, vector<int>& s, vector<int>& e){
	//버블 정렬
	for(int i=n-1; i>0;i--){
		for(int j=0; j<i;j++){
			if(e[j]>e[j+1]){
				swap(e[j], e[j+1]);
				swap(s[j], s[j+1]);
			}
		}
	}
}

int solution(int n, vector<int>& s, vector<int>& e){
	//1. 종료시간을 기준으로 먼저 정렬한다.
	sort(n, s, e);
	//2. 자리 변수 선언, -1로 초기화
	int e1 = -1, e2 = -1;
	int cnt = 0; //배정된 학생 수 카운트
	//3. 배열의 처음~끝까지 돌며 e1부터 시간 비교
	for(int i=0; i<n; i++){
		if(e1<= s[i]){ //새로운 학생이 e1에 배정될 수 있는 경우
			e1 = e[i];
			cnt++;
		}
		else if(e2<=s[i]){ //e2에 배정될 수 있는 경우
			//e1>=e2가 되도록 항상 유지한다.
			e2 = e1;
			e1 = e[i];
			cnt++;
		}
	}
	return cnt;
}

int main() {
	int n;
	vector<int> s, e;
	cin >> n;
	s.assign(n, 0);
	e.assign(n, 0);
	
	//입력
	for(int i=0; i<n; i++){
		cin >> s[i];
	}
	for(int i=0; i<n; i++){
		cin >> e[i];
	}
	
	//출력
	cout << solution(n, s, e);
	
	return 0;
}