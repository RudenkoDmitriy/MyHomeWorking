#include <stdio.h>
#include <iostream>

using namespace std;

int fibonacci (int element)
{
	if (element < 3)
	{
		return 1;
	}
	else
	{
		return fibonacci(element - 1) + fibonacci(element - 2);
	}
}

int main ()
{
	int element = 0;
	cout << "Enter number of Fibonacci's element(1, 1, 2...)" << endl;
	cin >> element;
	cout << "Answer: " << fibonacci(element) << endl;
	return 0;
}
