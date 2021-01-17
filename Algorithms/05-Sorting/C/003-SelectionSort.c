#include <stdio.h>

void swap(int *x, int *y)
{
    int temp = *x;
    *x = *y;
    *y = temp;
}

void selectionSort(int arr[], int n)
{
    int i = 0, j = 0, min_index = 0;
    
    for(i = 0; i < n - 1; i++)
    {
        min_index = i;
        for(j = i + 1; j < n; j++)
            if(arr[j] < arr[min_index])
                min_index = j;
        
        swap(&arr[i], &arr[min_index]);
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
    
    selectionSort(arr, n); 
    printf("Sorted array: \n"); 
    display(arr, n); 
    return 0; 
} 