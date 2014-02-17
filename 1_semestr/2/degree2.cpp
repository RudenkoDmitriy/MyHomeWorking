#include <stdio.h>
#include <iostream>

using namespace std;

int involution (int value, int degree, int result)
{
	if (degree >= 1)
	{
		if ((degree % 2) == 1)
		{
			result = result * value;
		}
		value *= value;
		result = involution (value, degree / 2 , result);
	}
	return result;
}

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
		int result = 1;
		cout << "Answer: " << involution (value, degree, result) << endl;
		return 0;
	}
}