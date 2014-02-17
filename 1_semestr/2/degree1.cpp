#include <stdio.h>
#include <iostream>

using namespace std;

int main()
{
	int value = 0;
	cout << "Enter value" << endl;
	cin >> value;
	int degree = 0;
	cout << "Enter degree" << endl;
	cin >> degree;
	if (degree <= 0)
	{
		cout << "Not correct degree" << endl;
	}
	else
	{
		int involution = 1;
		for (int i = 0; i < degree; i++)
		{
			involution = involution * value;
		}
		cout << "Answer: " << involution << endl;
	}
	return 0;
}