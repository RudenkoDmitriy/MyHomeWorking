#include "makeArr.h"
#include <stdio.h>
#include <iostream>
#include <time.h>

void makeArr(int arr[], int sizeOfArray)
{
	srand(time(nullptr));
	for (int i = 0; i < sizeOfArray; i++) 
	{
		arr[i] = rand() % 10;
		printf("%d ", arr[i]);
	}
}