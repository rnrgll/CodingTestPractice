//프로그래머스에서는 main함수 및 입출력문이 필요하지 않습니다. 대신 solution함수만 작성하면 됩니다.
#include <iostream>
#include <string>

using namespace std;


string solution(string input){
	string ans = ""; //답
	int cnt = 0; //문자 개수 카운트
	
	for(int i = 0; i<=input.size()-2; i++){
		if(input[i]==input[i+1]){ //현재 문자와 다음 문자가 같은 경우
			cnt++;
		}
		else{ //현재 문자와 다음 문자가 다른 경우
			ans += 'A' + cnt;
			cnt = 0;
		}
	}
	ans += 'A' + cnt; //마지막 문자도 추가
	
	return ans;
}

int main(){
	string input;
	cin >> input;
	cout << solution(input);
	return 0;
}