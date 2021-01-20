#include <stdio.h>

void shellSort(int arr[], int size)
{
    int gap = 0;
    int temp = 0;
    int i = 0;
    int j = 0;
    
    for(gap = size/2 ; gap > 0 ; gap /= 2)
    {
        for( i = gap ; i < size ; i++)
        {
            temp = arr[i];
            for( j = i ; j >= gap && arr[j - gap] > temp ; j -= gap)
                arr[j] = arr[j - gap];
                
            arr[j] = temp;
        }
    }
}

void display(int arr[], int size)
{
    int i = 0;
    for(i = 0; i < size; i++)
        printf("%d ", arr[i]);
}

int main() 
{ 
    int arr[] = {64, 25, 12, 22, 11}; 
    int n = sizeof(arr)/sizeof(arr[0]); 
    
    printf("Unsorted array: \n");
    display(arr, n);
    printf("\n");
    
    shellSort(arr, n); 
    printf("Sorted array: \n"); 
    display(arr, n); 
    return 0; 
} 
