#include <stdio.h>

int getMax(int arr[], int size)
{
    int max = arr[0];
    int i = 0;
    for( i = 0 ; i < size ; i++ )
        if( arr[i] > max )
            max = arr[i];
            
    return max;
}

void countSort(int arr[], int size, int exp)
{
    int output[size];
    int i = 0;
    int count[10] = {0};
    
    for ( i = 0 ; i < size ; i++ )
        count[(arr[i]/exp) % 10]++;
        
    for ( i = 1 ; i < 10 ; i++ )
        count[i] += count[i - 1];
        
    for ( i = size - 1 ; i >= 0 ; i-- )
    {
        output[count[(arr[i] / exp) % 10 ] - 1] = arr[i];
        count[(arr[i] / exp) % 10 ]--;
    }

    for ( i = 0 ; i < size ; i++ )
        arr[i] = output[i];
}

void radixSort(int arr[], int size)
{
    int max = getMax(arr, size);
    int exp = 0;
    
    for ( exp = 1 ; max / exp > 0 ; exp *= 10)
        countSort(arr, size, exp);
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
    
    radixSort(arr, n); 
    printf("Sorted array: \n"); 
    display(arr, n); 
    return 0; 
} 
