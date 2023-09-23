#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int solution(int h, int w, vector<int>& heights){
    int ans = 0;
    int left = 0, right = 0;
    
    for(int i = 1; i<=w-2; i++){
        //1. 왼쪽 오른쪽 그릇 높이 찾기
        left = *max_element(heights.begin(), heights.begin()+i);
        right = *max_element(heights.begin()+i+1, heights.end());
        //2. 빗물의 양 = max(0, min(left, right) - 현재 블록 높이)
        ans += max(0, min(left, right)-heights[i]);
    }
    return ans;
}

int main(){
    int h, w;
    vector<int> heights;
    cin >> h >> w;
    heights.assign(w, 0);
    
    for(int i=0; i<w; i++){
        cin >> heights[i];
    }
    
    cout << solution(h, w, heights);
    
    return 0;
}