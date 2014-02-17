#include <stdio.h>
#include <stdlib.h>
#include <iostream>
#include <time.h>

using namespace std;

void exchange(int mas[], int left, int right)
{
			int temp = 0;
			temp = mas[left];
			mas[left] = mas[right];
			mas[right] = temp;
}
int main()
{
	srand (time(NULL));
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
	int firstElement = mas[0];
	int count = 1;
	for (int i = 1; i < sizeOfMas; i++)
	{
		if (mas[i] < firstElement)
		{
			exchange(mas, i, count);
			count++;
		}
	}
	mas[0] = mas[count - 1] + mas[0];
	mas[count - 1] = mas[0] - mas[count - 1];
	mas[0] = mas[0] - mas[count - 1];
	int leftBorder = count - 2;
	for (int i = 0; i < count - 1; i++)
	{
		if (mas[i] == firstElement)
		{
			exchange(mas, i, count);
			count--;
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