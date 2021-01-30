#include <stdio.h>
#include <limits.h>

void stockBuySell(int price[], int n)
{
    int i = 0;
    int sell = -1;
    int buy = -1;
    
    if ( n == 1 )
        return;
        
    while ( i < n - 1 )
    {
        while (( i < n - 1 ) && (price[i + 1] <= price[i]))
            i++;
            
        if (i == n - 1)
            break;
            
        buy = i++;
        
        while ((i < n) && (price[i] >= price[i - 1]))
            i++;

        sell = i - 1;
 
        printf("(%d %d) ", buy, sell);
    }
}

int main()
{
    int price[] = { 100, 180, 260, 310, 40, 535, 695 };
    int n = sizeof(price) / sizeof(price[0]);

    stockBuySell(price, n);
 
    return 0;
}