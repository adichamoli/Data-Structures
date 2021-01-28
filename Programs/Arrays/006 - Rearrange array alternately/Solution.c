#include <stdio.h>

void rearrange(int arr[], int n)
{
    int max_ele = arr[n -1];
    int min_ele = arr[0];
    int i = 0;
    
    for( i = 0 ; i < n ; i++ )
    {
        if( i % 2 == 0 )
        {
            arr[i] = max_ele;
            max_ele -= 1;
        }
        else
        {
            arr[i] = min_ele;
            min_ele += 1;
        }
    }
}

int main() 
{ 
    int arr[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; 
    int n = sizeof(arr) / sizeof(arr[0]); 
  
    printf("Original Array\n"); 
    for (int i = 0; i < n; i++) 
        printf("%d ", arr[i]); 
  
    rearrange(arr, n); 
  
    printf("\nModified Array\n"); 
    for (int i = 0; i < n; i++) 
        printf("%d ", arr[i]); 
    return 0; 
} 