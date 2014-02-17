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
	int range = 0;
	cout << "Enter range [0;N) N = ";
	cin >> range;
	int *mas = new int[sizeOfMas];
	int *masOfCounting = new int[range];
	for (int i = 0; i < range; i++)
	{
		masOfCounting[i] = 0;
	}
	for (int i = 0; i < sizeOfMas; i++)
	{
		mas[i] = rand() % range;
		cout << mas[i] << " ";
		masOfCounting[mas[i]]++;
	}
	cout << endl;
	int count = 0;
	for (int i = 0; i < range; i++)
	{
		for (int j = 0; j < masOfCounting[i]; j++)
		{
			mas[count] = i;
			cout << mas[count] << " ";
			count++;
		}
	} 
	cout << endl;
	delete[] mas;
	delete[] masOfCounting;
	return 0;
}
