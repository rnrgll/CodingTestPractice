#include <bits/stdc++.h>
using namespace std;


const int MAX = 1000000;

int main(){
    ios::sync_with_stdio(0);
    cin.tie(0);

    int array[MAX+1] = {}; //
    int n, x, num, cnt=0;

    cin >> n;
    for(int i=0; i<n; i++){
        cin >> num;
        array[num]++;
    }

    cin >> x;

    for(int i=1; i<=x/2; i++){
        int complement = x-i;
        if(complement == i) continue; //i<j 조건
        if(complement<=MAX && array[i]>0 && array[complement]>0){ //out of index error 해결
            cnt++;
            array[i] = array[complement] = 0;
        }
        
    }

    cout << cnt;

    return 0;
}