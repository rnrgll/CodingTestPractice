#include <iostream>
#include <vector>


using namespace std;


void dfs(int x, int y, int n, int m, vector<vector<char>>& board, vector<vector<bool>>& visited){
    int nx = x, ny = y; //다음 칸의 좌표
    //1.현재 칸의 방문을 기록한다.
    visited[x][y] = true;
    //2. 탐색 방향을 결정한다.
    if(board[x][y]=='-'){
        ny += 1;
    }
    else {
        nx += 1;
    }
    //3. 탐색 조건을 만족하는지 확인한다.
    //보드를 벗어나지 않고, 현재 칸과 무늬가 동일하고, 아직 방문하지 않았다면..
    if(nx<n && ny<m && board[x][y]==board[nx][ny] && !visited[nx][ny]){
        dfs(nx, ny, n, m, board, visited);
    }
}


int solution(int n, int m, vector<vector<char>> &board){
    vector<vector<bool>> visited(n, vector<bool>(m, false));
    int cnt = 0;
    
    for(int i=0; i<n; i++){
        for(int j=0; j<m; j++){
            if(visited[i][j]){//방문한 적 있다면 지나친다.
                continue;
            }
            dfs(i, j, n, m, board, visited);
            //탐색이 끝나면 바닥 장식 하나 증가시킨다.
            cnt++;
        }
    }
    return cnt;
}


int main(){
    int n, m;
    cin >> n >> m;
    vector<vector<char>> board(n, vector<char>(m, ' '));
    for(int i=0; i<n; i++){
        for(int j=0; j<m; j++){
            cin >> board[i][j];
        }
    }
    
    cout << solution(n, m, board);
    
    return 0;
}