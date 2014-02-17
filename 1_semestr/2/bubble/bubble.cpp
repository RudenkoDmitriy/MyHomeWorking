#include <stdio.h>
#include <iostream>
#include <time.h>

using namespace std;

int main()
{
	srand(time(NULL));
	int sizeOfMas = 0;
	cout << "Enter size of massive" << endl;
	cin >> sizeOfMas;
	int *mas = new int[sizeOfMas];
	for (int i = 0; i < sizeOfMas; i++)
	{
		mas[i] = rand() % 100;
		cout << mas[i] << " ";
	}
	cout << endl;
	for (int i = sizeOfMas - 1; i > 0; i--)
	{
		for (int j = sizeOfMas - 1; j > 0 ; j--)
		{
			if (mas[j] < mas[j-1])
			{
				int temp = mas[j];
				mas[j] = mas[j-1];
				mas[j-1] = temp;
			}
		}
	}
	for (int i = 0; i < sizeOfMas; i++)
	{
		cout << mas[i] << " ";
	}
	cout << endl;
	delete[] mas;
	return 0;
}