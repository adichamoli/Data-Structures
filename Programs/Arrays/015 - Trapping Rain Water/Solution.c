#include <stdio.h>

#define max(a,b) \
   ({ __typeof__ (a) _a = (a); \
       __typeof__ (b) _b = (b); \
     _a > _b ? _a : _b; })
     
#define min(a,b) \
   ({ __typeof__ (a) _a = (a); \
       __typeof__ (b) _b = (b); \
     _a < _b ? _a : _b; })

int findWater(int arr[], int n)
{
    int left[n];
    int right[n];
    int water = 0;
    int i = 0;
    
    left[0] = arr[0];
    
    for ( i = 1 ; i < n ; i++ )
        left[i] = max(left[i - 1], arr[i]);
        
    right[n - 1] = arr[n - 1];
    
    for ( i = n - 2 ; i >= 0 ; i-- )
        right[i] = max(right[i + 1], arr[i]);
        
    for ( i = 0 ; i < n ; i++ )
        water += (min(left[i], right[i]) - arr[i]);
        
    return water;
}

int main()
{
    int arr[] = { 3,0,0,2,0,4 };
    int n = sizeof(arr) / sizeof(arr[0]);
    printf("Maximum water that can be accumulated : %d", findWater(arr, n));
    return 0;
}