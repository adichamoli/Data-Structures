#include <stdio.h>

int equilibrium(int arr[], int n)
{
    int i = 0;
    int sum = 0;
    int leftSum = 0;
    
    for ( i = 0 ; i < n ; i++ )
        sum += arr[i];
        
    for ( i = 0 ; i < n ; i++ )
    {
        sum -= arr[i];
        
        if( leftSum == sum )
            return i + 1;
            
        leftSum += arr[i];
    }
    
    return -1;
}

int main() 
{ 
    int arr[] = { 1,3,5,2,2 }; 
    int arr_size = sizeof(arr) / sizeof(arr[0]); 
    printf("First equilibrium index : %d", equilibrium(arr, arr_size)); 
    return 0; 
} 
