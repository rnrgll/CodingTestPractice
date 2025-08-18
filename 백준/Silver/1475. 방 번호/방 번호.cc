#include <bits/stdc++.h>
using namespace std;


int findMaxCnt(int (&cnt)[10]){
    return *max_element(cnt, cnt+10);
}

int main(){
    ios::sync_with_stdio(0);
    cin.tie(0);

    int cnt[10] = {};
    int roomNum;

    cin >> roomNum;
    while(roomNum>0){
        int num = roomNum % 10;
        if(num==6 || num==9){
            if(cnt[6]<cnt[9]) cnt[6]++;
            else if(cnt[6]>cnt[9]) cnt[9]++;
            else cnt[num]++;
        }
        else cnt[num]++;

        roomNum/=10;
    }

    cout <<findMaxCnt(cnt);


    return 0;
}