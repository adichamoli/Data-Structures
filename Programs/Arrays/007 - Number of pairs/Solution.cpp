#include <iostream>
#include <algorithm>

using namespace std;

int count(int x, int Y[], int n, int no_of_y[]) {
   if (x == 0)
      return 0;  
   if (x == 1)
   return no_of_y[0];
   int* index = upper_bound(Y, Y + n, x);
   int ans = (Y + n) - index;
   ans += (no_of_y[0] + no_of_y[1]);
   if (x == 2)
      ans -= (no_of_y[3] + no_of_y[4]);
   if (x == 3)
      ans += no_of_y[2];
   return ans;
}
int countPairs(int X[], int Y[], int m, int n) {
   int no_of_y[5] = {0};
   for (int i = 0; i < n; i++)
      if (Y[i] < 5)
         no_of_y[Y[i]]++;
   sort(Y, Y + n);
   int total_pairs = 0;
   for (int i=0; i< m; i++)
      total_pairs += count(X[i], Y, n, no_of_y);
   return total_pairs;
}
int main() {
   int X[] = {2, 1, 6};
   int Y[] = {1, 5};
   int m = sizeof(X)/sizeof(X[0]);
   int n = sizeof(Y)/sizeof(Y[0]);
   cout << "Total pair count: " << howManyPairs(X, Y, m, n);
}