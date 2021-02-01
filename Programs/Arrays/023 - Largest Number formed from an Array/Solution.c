#include <stdio.h>
#include <string.h>
#include <stdlib.h>

/*
Note - An element of arr is of type char*, and the const void* in
compare point to *char, so what is actually being passed is a char**.
Therefore, proper cast is *(const char**)a
*/
int compare(const void *a, const void *b)
{
	const char **X = (const char **)a;
	const char **Y = (const char **)b;

	int len = strlen(*X) + strlen(*Y) + 1;

	// create a new string X + Y
	char XY[len];
	strcpy(XY, *X);
	strcat(XY, *Y);

	// create a new string Y + X
	char YX[len];
	strcpy(YX, *Y);
	strcat(YX, *X);

	// larger of YX and XY should come first in sorted array
	return strcmp(YX, XY);
}

int main(void)
{
	char *arr[] = { "54", "546", "548", "60" };
	int n = sizeof(arr)/sizeof(arr[0]);

	// custom sort
	qsort(arr, n, sizeof(arr[0]), compare);

	// print the sorted sequence
	for (int i = 0; i < n ; i++ )
		printf("%s", arr[i]);

	return 0;
}