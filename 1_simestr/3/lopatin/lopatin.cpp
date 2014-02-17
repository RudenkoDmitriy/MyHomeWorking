#include <stdio.h>
#include <iostream>
#include <time.h>
#include <stdlib.h>

using namespace std;

bool binarySearch(int arr[], int left, int right, int value)
{
	if ((right - left) >= 0) 
	{
		if ((arr[(right + left) / 2] == value) )
		{
			return true;
		}
		else
		{
			if (value < arr[(right + left) / 2])
			{
				binarySearch(arr, left, (right + left) / 2 - 1, value);
			}
			else
			{
				binarySearch(arr, (right + left) / 2 + 1, right, value);
			}
		}
	}
	else
	{
		return false;
	}
}

void qsort(int arr[], int left, int right)
{
	srand(time(nullptr));
	int leftCount = left;
	int rightCount = right;
	int key = arr[rand() % (right - left + 1) + left];
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

int main()
{
	srand(time(nullptr));
	int n = 0;
	cout << "Enter value of n" << endl;
	cin >> n;
	int k = 0;
	cout << "Enter value of k" << endl;
	cin >> k;
	int *arr = new int [n];
	for (int i = 0; i < n; i++)
	{
		arr[i] = rand() % 1000000001;
		cout << arr[i] << " ";
	}
	cout << endl;
	qsort(arr, 0, n - 1);
	for (int i = 0; i < k; i++)
	{
		bool test = false;
		int k = rand() % 1000000001;
		cout << k << " ";
		test = binarySearch(arr, 0, n-1, k);
		if (test)
		{
			cout << "True" << endl;
		}
		else
		{
			cout << "False" << endl;
		}
	}
	delete[] arr;
	return 0;
}
