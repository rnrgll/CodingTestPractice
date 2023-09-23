#include <iostream>
#include <vector>

using namespace std;

void postOrder(int left, int right, vector<int>& preorder, vector<int>& postorder){
    if(left>right){
        return;
    }
    int root = preorder[left];
    int temp = left+1; //초기화 필수!! 그래야 재귀 종료 가능
    //오른쪽 서브트리가 시작하는 인덱스 찾기
    for(int i=left+1; i<=right; i++){ //1부터 시작하면 시간 초과 발생!! 현재 트리의 루트 다음 인덱스(=left+1)부터 시작해야 함
        if(root < preorder[i]){
            temp = i;
            break;
        }
    }
    //왼쪽 서브트리 탐색 -> 오른쪽 서브트리 탐색 -> 루트노드
    postOrder(left+1, temp-1, preorder, postorder);
    postOrder(temp, right, preorder, postorder);
    postorder.push_back(root); //루트 노드 입력
}

vector<int> solution(int n, vector<int>& preorder){
    vector<int> postorder;
    
    postOrder(0, preorder.size()-1, preorder, postorder);
    
    return postorder;
}



int main(){
    ios::sync_with_stdio(false);
    cin.tie(0);
    cout.tie(0);
    
    int n;
    vector<int> preorder;
    while(cin>>n){
        preorder.push_back(n);
    }
    vector<int> postorder = solution(n, preorder);
    for(int i=0; i<postorder.size(); i++){
        cout << postorder[i] << '\n';
    }
    return 0;
}
