#include "qsort.h"
#include "swap.h"
#include <iostream>
#include <time.h>

//'qsort' sorts elemnts of massive.
//Are input array, left and right border.
//Are output sorted array.

void myWork::qsort(int array[], int left, int right)
{
	srand(time(nullptr));
	int key = array[rand() % (right - left + 1) + left];
	int leftCount = left;
	int rightCount = right;
	while (leftCount < rightCount)
	{
		while (array[leftCount] < key)
		{
			leftCount++;
		}
		while (array[rightCount] > key)
		{
			rightCount--;
		}
		if (leftCount <= rightCount)
		{
			myWork::swap(array[leftCount], array[rightCount]);
			leftCount++;
			rightCount--;
		}
	}
	if (leftCount < right)
	{
		qsort(array, leftCount, right);
	}
	if (rightCount > left)
	{
		qsort(array, left, rightCount);
	}
}


