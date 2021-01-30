#include <stdio.h>
#include <stdbool.h>
#include <math.h>
#include <string.h>

#define max(a,b) \
   ({ __typeof__ (a) _a = (a); \
       __typeof__ (b) _b = (b); \
     _a > _b ? _a : _b; })

bool checkTriplet(int arr[], int n)
{
    int maximum = 0;
    int i = 0;
    int val = 0;
    int j = 0;
    int length = 0;
    
    for ( i = 0 ; i < n ; i++ )
    {
        maximum = max(maximum, arr[i]);
    }
      
    length = maximum + 1; 
    int hash[length];  
    
    memset(hash, 0, length);
    
    for ( i = 0 ; i < n ; i++ )
        hash[arr[i]]++;
        
    for ( i = 1 ; i < maximum + 1 ; i++ )
    {
        if ( hash[i] == 0 )
            continue;
            
        for ( j = 1 ; j < maximum + 1 ; j++ )
        {
            if (( i == j && hash[i] == 1) || hash[j] == 0 )
                continue;
                
            val = sqrt( (i * i) + (j * j) );
            
            if ((val * val) != ((i * i) + (j * j)))
                continue;
                
            if ( val > maximum )
                continue;
                
            if ( hash[val])
            {
                return true;
            }
        }
    }
    
    return false;
}

int main() 
{ 
    int arr[] = { 3, 2, 4, 6, 5 }; 
    int n = sizeof(arr) / sizeof(arr[0]); 
    if (checkTriplet(arr, n)) 
        printf("Yes"); 
    else
        printf("No"); 
}