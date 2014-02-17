#include <stdio.h>
#include <iostream>
#include <math.h>
#include <time.h>

using namespace std;

void revolution (int mas[], int left, int right)
{
	int count = 0;
	for (int i = 0; i <= (right - left) / 2; i++)
	{
		int temp = mas[left + count];
		mas[left + count] = mas[right - count];
		mas[right - count] = temp;
		count++;
	}
}

int main()
{
	srand (time(NULL));
	int left = 0;
	int right = 0;
	cout << "Enter left border" << endl;
	cin >> left;
	cout << "Enter right border" << endl;
	cin >> right;
	int bord = left + right;
	int *mas = new int[bord];
	const int sizeOfMas = bord - 1;
	for (int i = 0; i <= sizeOfMas; i++)
	{
		mas[i] = rand() %100;
		cout << mas[i] << " ";
	}
	revolution (mas, left, sizeOfMas);
	revolution (mas, 0, left - 1);
	revolution (mas, 0, sizeOfMas);
	cout << endl;
	for (int i = 0; i <= (bord - 1); i++)
	{
		cout << mas[i] << " ";
	}
	cout << endl;
	delete[] mas; 
	return 0;
}