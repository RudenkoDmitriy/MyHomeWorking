#include <stdio.h>
#include <iostream>
#include <fstream>

using namespace std;

//Reading symbol by symbol from text.txt
//If the string comes across at least one symbol other than '\n', '\t', ' ', string is not empty.

int main()
{
	ifstream text("text.txt");
	int count = 0;
	char symbol = 0;
	while (symbol != EOF)
	{
		bool test = false;
		while (symbol != '\n' )
		{
			symbol = text.get();
			if (symbol != '\n' && symbol != '\t' && symbol != ' ')
			{
				test = true; 
			}	
		}
		if (test)
		{
			count++;
		}
		symbol = text.get();
	}
	cout << "Number of not empty lines=" << count << endl;
	text.close();
	return 0;
}