/******************************************************************************

                            Online C Compiler.
                Code, Compile, Run and Debug C program online.
Write your code in this editor and press "Run" button to compile and execute it.

*******************************************************************************/

#include <stdio.h>

void insertionSort(int arr[], int n)
{
    int i = 0, j = 0, key = -1;
    
    for(i = 1; i < n; i++)
    {
        key = arr[i];
        j = i -1;
        
        while(j >= 0 && arr[j] > key)
        {
            arr[j + 1] = arr[j];
            j = j - 1;
        }
        
        arr [j + 1] = key;
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
    
    insertionSort(arr, n); 
    printf("Sorted array: \n"); 
    display(arr, n); 
    return 0; 
} 