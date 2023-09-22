#include <iostream>
#include <vector>
#include <map>
#include <sstream>

using namespace std;

int dayToNum(const string today){
    int num = 0;
    int y, m, d;
    char dot;
    
    stringstream ss(today);
    ss >> y >> dot >> m >> dot >> d;
    
    num = y*12*28 + (m-1)*28 + d; //1월부터 시작하므로 m-1 해야함!
    return num;
}

vector<int> solution(string today, vector<string> terms, vector<string> privacies){
    vector<int> result;
    map<char, int> term_map;
    
    //1. today 날짜 숫자로 변환 (숫자로 변환하는 함수 필요)
    int tday = dayToNum(today);
    //2. 약관 map에 저장 (반복자와 sstream을 이용해 파싱한다!!)
    for(auto iter: terms){
        char alphabet;
        int month;
        stringstream ss(iter);
        ss >> alphabet >> month;
        
        term_map[alphabet] = month;
    }
    //3. 개인정보 유효기간 지났는지 확인
    for(int i=0; i<privacies.size(); i++){
        char term = privacies[i].back(); //문자열 끝 문자 반환
        int expire = term_map[term]; //약관 종류에 따른 유효기간
        int expire_date = dayToNum(privacies[i].substr(0, privacies[i].size()-2)) + expire*28; //개인정보 만료일 계산
        
        if(tday >= expire_date){ //오늘 날짜가 만료일보다 최근인 경우 파기할 개인정보에 해당
            result.push_back(i+1); //개인정보 번호는 1부터 시작
        }
    }
    return result;    
    
}