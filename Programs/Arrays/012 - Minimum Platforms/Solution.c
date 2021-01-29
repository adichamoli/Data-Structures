#include <stdio.h>

#define max(a,b) \
   ({ __typeof__ (a) _a = (a); \
       __typeof__ (b) _b = (b); \
     _a > _b ? _a : _b; })

int findPlatform(int arr[], int dep[], int n)
{
    int platform_needed = 0;
    int result = 0;
    int i = 0;
    int j = 0;
    
    for ( i = 0 ; i < n ;  i++ )
    {
        platform_needed = 1;
        for ( j = i + 1 ; j < n ;  j++ )
        {
            if ( (arr[i] >= arr[j] && arr[i] <= dep[j]) || 
                 (arr[j] >= arr[i] && arr[j] <= dep[i]))
                platform_needed++;
            
            result = max(result, platform_needed);
        }
    }
    
    return result;
}

int main() 
{ 
    int arr[] = { 900, 940, 950, 1100, 1500, 1800 }; 
    int dep[] = { 910, 1200, 1120, 1130, 1900, 2000 }; 
    int n = sizeof(arr) / sizeof(arr[0]); 
    printf("Minimum Number of Platforms Required : %d", findPlatform(arr, dep, n)); 
    return 0; 
}
