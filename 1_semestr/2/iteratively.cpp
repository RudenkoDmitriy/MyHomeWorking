#include <stdio.h>
#include <iostream>

using namespace std;

int main()
{
	int element = 0;
	cout << "Enter number of Fibonacci's element (1, 1, 2...)" << endl;
	cin >> element;
	int mas[2] = {0};
	mas[0] = 0;
	mas[1] = 1;
	for (int i = 1; i < element; i++)
	{
		mas[1] = mas[0] + mas[1];
		mas[0] = mas[1] - mas[0];
	}
	cout << "Answer: " << mas[1] << endl;
	return 0;
}