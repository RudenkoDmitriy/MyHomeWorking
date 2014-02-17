#include <stdio.h>
#include <iostream>
#include <time.h>
#include "mergesort.h"
#include "createRandomLIst.h"

using namespace std;

//Function sorts element in  ascending order.
//Input is number of element.
//Output is sorting array.
//Test is positive with array of: 3 6 5 7 8 1 2.
//Test is negative with input data: "hjg".
int main()
{
	srand(time(NULL));
	int sizeOfArray = 0;
	cout << "Enter the size of array" << endl;
	cin >> sizeOfArray;
	bool test = 0;
	Position testOnConstr = NULL;
	List *list = createList(testOnConstr);
	createRandomList(list, sizeOfArray);
	printList(list);
	list = mergesort(list);
	printList(list);
	deleteList(list);
	return 0;
}