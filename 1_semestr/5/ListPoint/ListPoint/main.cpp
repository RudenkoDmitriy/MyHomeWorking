#include <stdio.h>
#include <iostream>
#include "List.h"

using namespace std;

//Interchange value in input positions.  
void swap(List *list, Position temp, Position next)
{
	changeValue(list, temp, returnByPos(list, temp) ^ returnByPos(list, next));
	changeValue(list, next, returnByPos(list, temp) ^ returnByPos(list, next));
	changeValue(list, temp, returnByPos(list, temp) ^ returnByPos(list, next));
}

//Insert head element to sort list.
void insertHeadToSort(List* list)
{
	for (Position temp = head(list); next(list,temp) != nullptr && returnByPos(list, temp) > returnByPos(list, next(list,temp)); temp = next(list,temp))
	{
		swap(list, temp, next(list, temp));
	}
}

//Function create a new empty list, sorting input data.
//Operations with list:
//0 - escape;
//1 - add value in list;
//2 - remove value;
//3 - print list.

//With values 2,3,113,124,43 test is positive.
//Negative test with value 's','4.3'.

int main()
{
	List *list = createList();
	int numberOfOperation = 1;
	cout << "Operations with list:" << endl;
	cout << "0 - escape;" << endl;
	cout << "1 - add value in list;"<< endl;
	cout << "2 - remove value;" << endl;
	cout << "3 - print list." << endl;
	while (numberOfOperation)
	{
		cout << "Enter the number of operation" << endl;
		cin >> numberOfOperation;
		switch (numberOfOperation)
		{
		case 0:
			{
				break;
			}
		case 1:
			{
				int addValue = 0;
				cout << "Enter the added value" << endl;
				cin >> addValue;
				insertToHead(list, addValue);
				insertHeadToSort(list);
				break;
			}
		case 2:
			{
				int removValue = 0;
				cout << "Enter the removed value" << endl;
				cin >> removValue;
				remove(list, returnPos(list, removValue));
				break;
			}
		case 3:
			{
				print(list);
				break;
			}
		default:
			{
				cout << "Incorrect value" << endl;
				break;
			}
		}
	}
	deleteList(list);
	return 0;
}