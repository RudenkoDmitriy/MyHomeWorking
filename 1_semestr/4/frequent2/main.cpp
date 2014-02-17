#include "qsort.h"
#include "counting.h"
#include <stdio.h>
#include <iostream>
#include <time.h>
#include <fstream>

using namespace std;

//Array is read from "array.txt"
//First line - size of array. 
//The result is possible with 1 5 3 5 3 2 5 2 5. 

int main()
{
	srand(time(nullptr));
	int sizeOfArray = 0;
	ifstream file("array.txt");
	file >> sizeOfArray;
	int *arr = new int[sizeOfArray];
	for (int i = 0; i < sizeOfArray; i++)
	{
		file >> arr[i];
	}
	file.close();
	myWork::qsort(arr, 0, sizeOfArray - 1);
	int element = myWork::counting(arr, sizeOfArray);
	cout << "Frequent element-" << element << endl;
	delete[] arr;
	return 0;
}