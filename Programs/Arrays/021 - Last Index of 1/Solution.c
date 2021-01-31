#include <stdio.h>

int findIndex(int arr[], int idx, int K)
{
    if (idx < 0) 
        return -1; 
  
    if (arr[idx] == K) { 
        return idx; 
    } 
  
    return findIndex(arr, idx - 1, K);
}

int main() 
{ 
  
    int arr[] = { 0, 1, 1, 0, 1, 0, 0, 1 }; 
    int N = sizeof(arr) / sizeof(arr[0]); 
    int K = 1; 
  
    printf("%d", findIndex(arr, N - 1, K)); 
  
    return 0; 
} 
