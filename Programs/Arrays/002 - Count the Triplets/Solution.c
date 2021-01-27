#include <stdio.h>

int countWays(int arr[], int n)
{
    int freq[100] = {0}; 
      
    // Loop to count the frequency 
    for (int i=0; i < n; i++){ 
        freq[arr[i]]++; 
    } 
    int count = 0; 
      
    // Loop to count for triplets 
    for(int i = 0;i < n; i++){ 
        for(int j = i+1; j < n; j++){ 
            if(freq[arr[i] + arr[j]]){ 
                count++; 
            } 
        } 
    } 
    return count;
}

int main() 
{  
    int arr[]={1, 5, 3, 2};  
    int n = sizeof(arr)/sizeof(int);  
    printf("No of Triplets : %d", (countWays(arr, n)));  
    return 0; 
} 