#include <stdio.h>

int subArraySum(int arr[], int n, int sum)
{
    int curr_sum = arr[0];
    int start = 0;
    int i = 0;
    
    for( i = 1 ; i <= n ;  i++ )
    {
        while( curr_sum > sum && start < i - 1 )
        {
            curr_sum = curr_sum - arr[start];
            start++;
        }
        
        if( curr_sum == sum )
        {
            printf("Sum found between indexes %d and %d", start, i - 1);
            return 1;
        }
        
        if( i < n )
            curr_sum = curr_sum + arr[i];
    }
    
    printf("No SubArray Found");
    return 0;
}

int main() 
{ 
    int arr[] = { 15, 2, 4, 8, 9, 5, 10, 23 }; 
    int n = sizeof(arr) / sizeof(arr[0]); 
    int sum = 23; 
    subArraySum(arr, n, sum); 
    return 0; 
} 
