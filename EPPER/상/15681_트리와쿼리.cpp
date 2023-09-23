#include <iostream>
#include <vector>

using namespace std;

void dfs(int cur, int pre, const vector<vector<int>>& tree, vector<int>& dp){
    //현재 정점의 자식 노드를 탐색
    for(int i=0; i<tree[cur].size(); i++){
        if(tree[cur][i]==pre){ //부모 노드면 탐색하지 않는다.
            continue;
        }
        
        dfs(tree[cur][i], cur, tree, dp); //자식 노드를 루트로 하는 서브트리 dfs 탐색
        dp[cur] += dp[tree[cur][i]]; //현재 노드의 dp값 = 현재 노드 dp값 + 자식 노드의 dp값들의 합
    }
    return;
}

void solution(int cur, int pre, int q, const vector<vector<int>>& tree, vector<int> dp){
    int node;
    //1. dfs 알고리즘으로 dp 배열 완성하기
    dfs(cur, pre, tree, dp); 
    //2. 들어오는 쿼리에 대한 노드 값 출력
    while(q--){
        cin >> node;
        cout << dp[node] << '\n';
    }
}

int main() {
    ios::sync_with_stdio(false);
    cin.tie(0); cout.tie(0);
    
    int n, r, q, u, v;
    cin >> n >> r >> q;
    //노드 번호가 1부터 시작하므로 배열 크기는 n+1로 설정
    vector<vector<int>> tree(n+1, vector<int>(0)); //트리의 간선 정보를 저장
    vector<int> dp(n+1, 1); //자기 자신을 포함한 정점의 개수를 세므로 모두 1로 초기화한다.
    
    for(int i=0; i<n-1; i++){
        cin >> u >> v;
        tree[u].push_back(v);
        tree[v].push_back(u);
    }
    solution(r, 0, q, tree, dp);
    
    return 0;
}