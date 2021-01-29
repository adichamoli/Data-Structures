#include <stdio.h>
#include <limits.h>

void swap(int* a, int* b)
{
    int temp = *a;
    *a = *b;
    *b = temp;
}

int partition(int arr[], int left, int right)
{
    int x = arr[right];
    int i = left;
    int j = 0;
    
    for ( j = left ; j < right ; j++ )
    {
        if( arr[j] <= x )
        {
            swap(&arr[i], &arr[j]);
            i++;
        }
    }
    
    swap(&arr[i], &arr[right]);
    return i;
}

int kthSmallest(int arr[], int l, int r, int k)
{
    int pos = 0;
    if ( k > 0 && k <= r - l + 1 )
    {
        pos = partition(arr, l, r);
        
        if ( pos - l == k - 1 )
            return arr[pos];
            
        if ( pos - l > k -1 )
            return kthSmallest(arr, l, pos - 1, k);
            
        return kthSmallest(arr, pos + 1, r, k - pos + l - 1);
    }
    
    return INT_MAX;
}

int main() 
{ 
    int arr[] = { 12, 3, 5, 7, 4, 19, 26 }; 
    int n = sizeof(arr) / sizeof(arr[0]), k = 3; 
    printf("K'th smallest element : %d", kthSmallest(arr, 0, n - 1, k)); 
    return 0; 
}
