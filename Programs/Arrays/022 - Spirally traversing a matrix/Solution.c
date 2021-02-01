#include <stdio.h>

#define R 4
#define C 4

void print(int arr[R][C], int i, int j, int m, int n)
{
    int p = 0;
    
    if ( i >= m || j >= n )
        return;
        
    for ( p = j ; p < n ; p++ )
        printf("%d ", arr[i][p]);
        
    for ( p = i + 1 ; p < m ; p++ )
        printf("%d ", arr[p][n - 1]);
        
    if ( (m - 1) != i)
        for ( p = n - 2; p >= j ; p-- )
            printf("%d ", arr[m - 1][p]);
            
    if ( (n - 1) != j)
        for ( p = m - 2; p > i ; p-- )
            printf("%d ", arr[p][j]);
            
    print(arr, i + 1, j + 1, m - 1, n - 1);
}

int main()
{
 
    int a[R][C] = { { 1, 2, 3, 4 },
                    { 5, 6, 7, 8 },
                    { 9, 10, 11, 12 },
                    { 13, 14, 15, 16 } };
 
    print(a, 0, 0, R, C);
    return 0;
}
