#include <bits/stdc++.h>

using namespace std;

int main(void)
{
    ios::sync_with_stdio(0);
    cin.tie(0);

    string word;
    vector<int> cnt(26,0);
    cin >> word;

    for(char c:word){
        int idx = (int)c-'a';
        cnt[idx]++;
    }

    for(int n:cnt)
        cout << n << " ";


    return 0;

}