#include <stdio.h>
#include <limits.h>

int findElement(int arr[], int n)
{
    int element = arr[0], maxx = arr[0], bit = -1, check = 0;
    int idx = -1;
    int i = 0;
    
    if ( n == 1 || n == 2 )
        return -1;
        
    for ( i = 1 ; i < n - 1 ;)
    {
        if ( arr[i] < maxx && i < (n - 1))
        {
            i++;
            bit = 0;
        }
        else
        {
            if ( arr[i] >= maxx )
            {
                element = arr[i];
                idx = i;
                check = i;
                maxx = arr[i];
            }
            
            if ( check == 1 )
                i++;
                
            bit = 1;
            
            while ( arr[i] >= element && i < ( n - 1))
            {
                if(arr[i] > maxx)
                    maxx = arr[i];
                i++;
            }
            check = 0;
        }
    }
    
    if (element <= arr[n - 1] && bit == 1) 
    {
        return arr[idx];
    }
    else 
    {
        return -1;
    }
}

int main()
{
    int arr[] = { 4, 2, 5, 7 };
    int n = sizeof arr / sizeof arr[0];

    printf("Element : %d", findElement(arr, n));
    return 0;
}