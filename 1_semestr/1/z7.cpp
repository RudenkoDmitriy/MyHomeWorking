#include <stdio.h>
#include <iostream>

using namespace std;

int main()
{
	char s[255] = {0};
	cout << "Enter string" << endl;
	cin >> s;
	bool test = false;
	int count = 0;
	for (int i = 0; i < strlen(s); i++)
	{
		if (s[i] == '(')
		{ 
			count++;
		}
		if (s[i] == ')')
		{ 
			count--;
		}
		if (count < 0)
		{ 
			test = true;
			break;
		}

 	}
	if ((count == 0) && (!test))
	{ 
		cout << "all right!" << endl;
	}
	else
	{
		cout << "This expression have a troubles" << endl;
	}
	return 0;
}