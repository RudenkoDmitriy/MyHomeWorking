#include <stdio.h>
#include <iostream>
#include <time.h>

using namespace std;

void qsort(int array[], int left, int right)
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
			int temp = array[leftCount];
			array[leftCount] = array[rightCount];
			array[rightCount] = temp;
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

int main()
{
	srand(time(nullptr));
	int sizeOfArray = 0;
	cout << "Enter size of array" << endl;
	cin >> sizeOfArray;
	int* arr = new int[sizeOfArray];
	for (int i = 0; i < sizeOfArray; i++) // Test- result is positive with array 6 2 8 4 8 3 3 4 1 8
	{
		arr[i] = rand() % 10;
		cout << arr[i] <<" ";
	}
	cout << endl;
	qsort(arr, 0, sizeOfArray - 1);
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
	cout << "Frequent element-" << element << endl;
	delete[] arr;
	return 0;
}