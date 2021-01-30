#include <stdio.h>
#include <limits.h>

void swap(int* a, int* b) 
{ 
	int t = *a; 
	*a = *b; 
	*b = t; 
} 

int partition (int arr[], int low, int high) 
{ 
	int pivot = arr[high];
	int i = (low - 1);

	for (int j = low; j <= high- 1; j++) 
	{ 
		if (arr[j] < pivot) 
		{ 
			i++; 
			swap(&arr[i], &arr[j]); 
		} 
	} 
	swap(&arr[i + 1], &arr[high]); 
	return (i + 1); 
} 

void quickSort(int arr[], int low, int high) 
{ 
	if (low < high) 
	{ 
		int pi = partition(arr, low, high); 

		quickSort(arr, low, pi - 1); 
		quickSort(arr, pi + 1, high); 
	} 
}

int findMinDiff(int arr[], int n, int m)
{
    if (m==0 || n==0)
        return 0;
 
    quickSort(arr, 0, n);

    if (n < m)
       return -1;
       
    int min_diff = INT_MAX;
     
    for (int i=0; i+m-1<n; i++)
    {
        int diff = arr[i+m-1] - arr[i];
        if (diff < min_diff)
            min_diff = diff;
    }
    return min_diff;
}

int main()
{
    int A[] = { 12, 4, 7, 9, 2, 23, 25, 41, 30, 40, 28, 42, 30, 44, 48, 43, 50 };
    int m = 7;
    int N = sizeof(A) / sizeof(A[0]);
 
    printf("%d", findMinDiff(A, N, m));
}