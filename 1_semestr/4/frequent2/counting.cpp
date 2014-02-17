#include "counting.h"

//"counting" counts same elements of array and finds most frequent element.
//Are input array and size of array.
//Are output frequent element.

int myWork::counting(int arr[],int sizeOfArray)
{
	int maximum = 0;
	int element = 0;
	int testOfSizeOfArray = 0;
	while (testOfSizeOfArray != sizeOfArray)
	{
		int count = 0;
		int testElement = arr[testOfSizeOfArray];
		while (arr[testOfSizeOfArray] == testElement)
		{
			count++;
			testOfSizeOfArray++;
		}
		if (count >= maximum)
		{
			maximum = count;
			element = arr[testOfSizeOfArray - 1];
		}
	}
	return element;
}