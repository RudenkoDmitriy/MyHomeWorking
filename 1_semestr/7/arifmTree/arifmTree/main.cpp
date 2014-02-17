#include <stdio.h>
#include <iostream>
#include <fstream>
#include <string>
#include "binTree.h"

using namespace std;

//Function reading expression from file to string.
//Input is name of file.
//Output is string with expression.

string expression(string nameOfFile)
{
	ifstream text(nameOfFile);
	if(text)
	{
		string line = "";
		string temp = "";
		while (!text.eof())
		{
			text >> temp;
			line += temp;
		}
		return line;
	}
	else
	{
		return "Error";
	}
}

//Fuction create an arithmetic tree, print expression on the screen, counting expression and print result.
//Input is file with expression.
//Output expression and result of counting.
//Test is positive with data in file.
//Test if negative with : 7 * 8 - 3.

int main()
{
	string nameOfFile = "";
	cout << "Enter the name of file" << endl;
	cin >> nameOfFile;
	int firstReadingElement = 0;
	string testString = expression(nameOfFile);
	if (testString == "Error")
	{
		cout << "File don't exist" << endl;
	}
	else
	{
		BinTree *tree = createTree();
		tree = createArithmTree(tree, expression(nameOfFile), firstReadingElement);
		cout << "This is an expression, writed in file: ";
		printArithmTree(tree);
		cout << endl;
		bool test = 0;
		int result = countingArithmTree(tree, test);
		if (!test)
		{
			cout << "This is the result of counting: " << result << endl;
		}
		deleteBinTree(tree);
	}
	return 0;
}