#include <bits/stdc++.h>
using namespace std;


int cnt[10];

int main(){
    int a, b, c;
    cin >> a >> b >> c;
    int val = a*b*c;
    while(val!=0){
        cnt[val%10]++;
        val /=10;
    }

    for(int i=0; i<10; i++){
        cout << cnt[i] << "\n";
    }


    return 0;
}