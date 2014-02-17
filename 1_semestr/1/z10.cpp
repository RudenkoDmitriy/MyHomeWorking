#include <stdio.h>
#include <iostream>

using namespace std;

int main()
{
	int size = 0;
	cout << "Enter size of massive" << endl;
	cin >> size;
	int *mas = new int[size];
	cout << "Enter elements of massive" << endl;
	for (int i = 0; i <= size - 1; i++)
	{
		cin >> mas[i];
	}
	int value = 0;
	for (int i = 0;  i <= size - 1; i++)
	{
		if (mas[i] == 0)
		{ 
			value++;
		}
	}
	cout << "Number of zero-element " << value << endl;
	delete[] mas;
	return 0;
}