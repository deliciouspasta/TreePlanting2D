#include<iostream>

using namespace std;

int main(){
    int a,b,c;
    cin >> a;
    cin >> b;
    cin >> c;

    if(a < c < b || b < c < a){
        printf("Yes");
    }else{
        printf("No");
    }
}

#include<iostream>
#include<stdio.h>

using namespace std;

int main(void){
    int l, N,n,i = 0, S[N+1],K;

    cin >> N;
    n = N;
    for(i = 0; i < N; i++){
        cin >> l;
        S[i] = l;

    }

    cin >> K;
    S[K-1]

    for(int i = 0; i < N; i++){
        if(S[i] != S[K-1]){
            S[i] = '*'
        }
    }

    printf("%s\n",S);


}


