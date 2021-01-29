#include <stdio.h>
#include <math.h>
#include <stdlib.h>

int printGreater(int x[], int y[], int m, int n) 
{ 
    int pairs = 0;
    long double X = 0;
    long double Y = 0;
    int i = 0;
    int j = 0;
    
    for(i = 0 ; i < m; i++)
    {
        for(j = 0 ; j < n; j++)
        {
            X = y[j] * log(x[i]); 
            Y = x[i] * log(y[j]);  
            
            if (X > Y) 
            { 
                pairs++;
            } 
        }
    }
    
    return pairs;
} 
  
int main() 
{ 
    int X[] = {2, 3, 4, 5};  
    int Y[] = {1, 2, 3};  
  
    int m = sizeof(X)/sizeof(X[0]);  
    int n = sizeof(Y)/sizeof(Y[0]);
    
    int res = printGreater(X, Y, m, n); 
    printf("No of Pairs : <%d>\n", res);
    return 0; 
} 