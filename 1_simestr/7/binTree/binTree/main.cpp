#include <stdio.h>
#include <iostream>
#include <vector>
#include <time.h>
#include "binTree.h"

using namespace std;

//Function realises binary tree.
//Numbers of operation with tree:
//0 - exit.
//1 - insert in tree;
//2 - remove from tree
//3 - check availability;
//4 - enter contents of the tree in ascending order;
//5 - enter contents of the tree in descening order.
//Test is result with values: 3 8 1 8 2 7.
//Test is negative with error data: for example, "dd d".

int main()
{
	BinTree *tree = createTree();
	cout << "Numbers of operation with tree:" << endl;
	cout << "0 - exit"<< endl;
	cout << "1 - insert in tree;" << endl;
	cout << "2 - remove from tree;" << endl;
	cout << "3 - check availability;" << endl;
	cout << "4 - enter contents of the tree in ascending order;" << endl;
	cout << "5 - enter contents of the tree in descening order." << endl;
	int numberOfOperation = 0;
	while(true)
	{
		cout << "Enter the number of operation" << endl;
		cin >> numberOfOperation;
		switch(numberOfOperation)
		{
			case 1:
			{
				int value = 0;
				cout << "Enter the inserting value" << endl;
				cin >> value;
				tree = add_tree(tree, value);
				break;
			}
			case 2:
			{
				int value = 0;
				cout << "Enter the removing value" << endl;
				cin >> value;
				tree = removeKey(tree, value);
				break;
			}
			case 3:
			{
				int value = 0;
				cout << "Enter the cheking value" << endl;
				cin >> value;
				if (existKey(tree, value))
				{
					cout << value << " is in tree" << endl;
					break;
				}
				else
				{
					cout << value << " is not in tree" << endl;
				}
				break;
			}
			case 4:
			{
				printInAscending(tree);
				cout << endl;
				break;
			}
			case 5:
			{
				printInDecreasing(tree);
				cout << endl;
				break;
			}
			case 0:
			{
				break;
			}
			default:
			{
				cout << "Error: iy is not number of operation!" << endl;
			}
		}
		if (numberOfOperation == 0)
		{
			break;
		}
	}
	deleteBinTree(tree);
	return 0;
}