#include <stdio.h>
#include <stdbool.h>

void swap(int *xp, int *yp) 
{ 
    int temp = *xp; 
    *xp = *yp; 
    *yp = temp; 
}

void zigZag(int arr[], int n)
{
    bool flag = true;
    int i = 0;
    
    for ( i = 0; i <= n - 2 ; i++ )
    {
        if ( flag )
        {
            if ( arr[i] > arr[i + 1] )
                swap(&arr[i], &arr[i + 1]);
        }
        else
        {
            if ( arr[i] < arr[i + 1] )
                swap(&arr[i], &arr[i + 1]);
        }
        
        flag = !flag;
    }
}

int main()  
{  
    int arr[] = {4, 3, 7, 8, 6, 2, 1};  
    int n = sizeof(arr)/sizeof(arr[0]);  
    int i = 0;
    
    zigZag(arr, n);  
    
    for ( i = 0; i < n ; i++ )  
        printf("%d ", arr[i]);  
    
    return 0;  
} 
