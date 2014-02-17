#include <stdio.h>
#include <iostream>

using namespace std;

int main()
{
	int mas[28] = {0};
	for (int a = 0; a <= 9; a++)
	{
		for (int b = 0; b <= 9; b++)
		{
			for (int c = 0; c <= 9; c++)
			{
				mas[a + b + c]++;
			}
		}
	}
	int sum = 0;
	for (int i = 0; i <= 27; i++)
	{
		mas[i] = mas[i] * mas[i];
		sum = sum + mas[i];
	}
	cout << "answer" << endl << sum << endl;
	return 0;
}