#include <stdio.h>
#include <iostream>

using namespace std;

int main()
{
	int value = 0;
	cout <<"Enter number"<< endl;
	cin >> value;
	for (int i = 1; i <= value; i++)
	{   
		int test = 0;
		for (int k = 1; k <= i; k++)
		{
			if ((i % k) == 0)
			{
				test++;
			}
		}
		if (test == 2)
		{
			cout << i <<" ";
		}
	}
	cout << endl;
	return 0;
}