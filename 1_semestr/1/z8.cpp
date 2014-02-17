#include <stdio.h>
#include <iostream>

using namespace std;

int main()
{
	char s[255] = {0};
	cout << "Enter string" << endl;
	cin >> s;
	char s1[255] = {0};
	cout << "Enter substring" << endl;
	cin >> s1;
	int count = 0;
	for (int i1 = 0; i1 <= strlen(s) - strlen(s1) + 1; i1++)
	{
		bool test = false;
		for (int i2 = 0; i2 < strlen(s1); i2++)
		{   
			if (s1[i2] != s[i2+i1])
			{   
				test = true;
				break;
			}
		}
		if (!test)
		{
			count++;
		}
	}
	cout << count << endl;
	return 0;
}