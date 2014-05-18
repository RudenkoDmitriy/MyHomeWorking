#include <iostream>
#include <stdlib.h>
#include <vector>

using namespace std;

int main()
{
	int sizeOfArray = 0;
	int controlNumber= 0;
	cout << "Enter the size of array ";
	cin >> sizeOfArray;
	std::vector<int> myArray(sizeOfArray);
	if (sizeOfArray <= 0)
	{
		cout << "Error";
		return 1;
	}
	cout << "Enter the control number";
	cin >> controlNumber;
	for (int i = 0; i < sizeOfArray; i++)
	{
		cin >> myArray[i];
	}
	for (int i = sizeOfArray - 1; i >= 0; i--)
	{
		if (i % controlNumber == 0)
		{
			myArray.erase(myArray.begin() + i);
		}
	}
	for (int i = 0; i != myArray.size() / 2; i++)
	{
		swap(myArray[i * 2], myArray[i * 2 + 1]);
	}
	for (int i = 0; i != myArray.size(); i++)
	{
		cout << myArray[i] << " ";
	}
	return 0;
}