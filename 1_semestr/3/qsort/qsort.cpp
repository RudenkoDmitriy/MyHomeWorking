#include <stdio.h>
#include <iostream>
#include <time.h>
#include <stdlib.h>

using namespace std;

void makeArray(int arr[], int lengthOfArr)
{
	for (int i = 0; i < lengthOfArr; i++) //Test-result is positive with array:1 7 4 0 9 4 8 8 2 4
		{
			arr[i] = rand() % 10;
			printf("%d", arr[i]);
			printf("%c",' ');
		}
}

void writeArray(int arr[], int lengthOfArr)
{
	for (int i = 0; i < lengthOfArr; i++) 
		{
			printf("%d", arr[i]);
			printf("%c",' ');
		}
}

void insertion(int arr[], int left, int right)
{
	for (int i = left; i < right; i++)
	{
		int indexOfItemToCompare = i;
		while (indexOfItemToCompare >= 0 && arr[indexOfItemToCompare] > arr[indexOfItemToCompare + 1])
		{
			int temp = arr[indexOfItemToCompare];
			arr[indexOfItemToCompare] = arr[indexOfItemToCompare + 1];
			arr[indexOfItemToCompare + 1] = temp;
			indexOfItemToCompare--;
		}
	}
}

void qsort(int arr[], int left, int right)
{
	if ((right - left + 1) < 10)
	{
		insertion(arr, left, right);
	}
	else
	{
		srand(time(nullptr));
		int key = arr[rand() % (right - left + 1) + left];
		int leftCount = left;
		int rightCount = right;
		while (leftCount < rightCount)
		{
			while (arr[leftCount] < key)
			{
				leftCount++;
			}
			while (arr[rightCount] > key)
			{
				rightCount--;
			}
			if (leftCount <= rightCount)
			{
				int temp = arr[leftCount];
				arr[leftCount] = arr[rightCount];
				arr[rightCount] = temp;
				leftCount++;
				rightCount--;
			}
		}
		if (leftCount < right)
		{
			qsort(arr, leftCount, right);
		}
		if (rightCount > left)
		{
			qsort(arr, left, rightCount);
		}
	}
}

int main()
{
	srand(time(nullptr));
	int time1 = clock() / CLK_TCK;
	int lengthOfArr = 0;
	cout << "Enter length of array" << endl;
	cin >> lengthOfArr;
	int *arr = new int[lengthOfArr];
	makeArray(arr, lengthOfArr);
	cout << endl;
	qsort(arr, 0, lengthOfArr - 1);
	writeArray(arr, lengthOfArr);
	delete[] arr;
	int time2 = clock() / CLK_TCK;
	int timePeriod = time2 - time1;
	std::cout << timePeriod / 60  << " " << timePeriod   % 60;
	return 0;	
}
