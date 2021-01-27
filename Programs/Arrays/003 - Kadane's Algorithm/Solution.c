#include <stdio.h>

#define max(a,b) \
   ({ __typeof__ (a) _a = (a); \
       __typeof__ (b) _b = (b); \
     _a > _b ? _a : _b; })

int maxSubArraySum(int arr[], int n)
{
    int max_so_far = arr[0];
    int curr_max = arr[0];
    int i = 0;
    
    for( i = 0 ; i < n ; i++ )
    {
        curr_max = max(arr[i], curr_max + arr[i]);
        max_so_far = max(max_so_far, curr_max);
    }
    
    return max_so_far;
}

int main() 
{ 
    int a[] = {-2, -3, 4, -1, -2, 1, 5, -3}; 
    int n = sizeof(a)/sizeof(a[0]); 
    int max_sum = maxSubArraySum(a, n); 
    printf("Maximum contiguous sum : %d", max_sum); 
    return 0; 
}