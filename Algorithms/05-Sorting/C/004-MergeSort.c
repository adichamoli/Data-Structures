#include <stdio.h>

void merge(int arr[], int left, int mid, int right)
{
    int i, j, k;
    int n1 = mid - left + 1;
    int n2 = right - mid;
    
    int first[n1], second[n2];
    
    for(i = 0; i < n1; i++)
        first[i] = arr[left + i];
    
    for(i = 0; i < n2; i++)
        second[i] = arr[mid + i + 1];
        
    i = 0;
    j = 0;
    k = left;
    
    while( i < n1 && j < n2)
    {
        if(first[i] <= second[j])
        {
            arr[k] = first[i];
            i++;
        }
        else
        {
            arr[k] = second[j];
            j++;
        }
        k++;
    }
    
    while( i < n1 )
    {
        arr[k] = first[i];
        i++;
        k++;
    }
        
    while( j < n2 )
    {
        arr[k] = second[j];
        j++;
        k++;
    }
}

void mergeSort(int arr[], int left, int right)
{
    int mid = -1;
    if(left < right)
    {
        mid = left + (right - left) / 2;
        
        mergeSort(arr, left, mid);
        mergeSort(arr, mid + 1, right);
        
        merge(arr, left, mid, right);
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
    
    mergeSort(arr, 0, n - 1); 
    printf("Sorted array: \n"); 
    display(arr, n); 
    return 0; 
} 