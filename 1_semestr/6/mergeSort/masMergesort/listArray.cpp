#include "listArray.h"
#include <stdio.h>
#include <iostream>

struct ListArray
{
	TypeOfValue *array;
	int last;
	TypeOfSize sizeOfArray;
};

ListArray *createList(int test)
{
	ListArray *list = new ListArray;
	list->array = new TypeOfValue[100];
	list->sizeOfArray = 100;
	list->last = -1;
	return list;
}

int head(ListArray *list)
{
	return 0;
}

int firstElement(ListArray *list)
{
	return 0;
}

int last(ListArray *list)
{
	return list->last + 1;
}

int next(ListArray *list, int position)
{
	return position + 1;
}

void insert(ListArray *list, TypeOfValue element, int position)
{
	if (list->last < list->sizeOfArray - 1)
	{
		for (int temp = last(list); temp != position; temp--)
		{
			list->array[temp] = list->array[temp + 1];
		}
		list->array[position] = element;
		list->last++;
	}
	else 
	{
		TypeOfValue *newArray = new TypeOfValue[list->sizeOfArray * 2];
		for (int temp = 0; temp != last(list); temp++)
		{
			newArray[temp] = list->array[temp];
		}
		TypeOfValue *ptr = list->array;
		list->array = newArray;
		list->sizeOfArray = list->sizeOfArray * 2;
		for (int temp = last(list); temp != position; temp--)
		{
			list->array[temp] = list->array[temp + 1];
		}
		list->array[position] = element;
		list->last++;
		delete ptr;
	}
}


void remove(ListArray *list, int position)
{
	for (int temp = position; temp != last(list); temp++)
	{
		list->array[temp] = list->array[temp + 1];
	}
	list->last--;
}

void changeValue(ListArray *list, int position, TypeOfValue value)
{
	list->array[position] = value;
}

void copy(ListArray *list, TypeOfValue record, int position)
{
	list->array[position] = record;
}

int middle(ListArray *list)
{
	return list->last / 2;
}

TypeOfSize length(ListArray *list)
{
	return list->last + 1;
}

int returnPos(ListArray *list, TypeOfValue value)
{
	for (int temp = 0; temp != last(list); temp++)
	{
		if (list->array[temp] == value)
		{
			return temp;
		}
	}
	return NULL;
}

TypeOfValue returnByPos(ListArray *list, int position)
{
	return list->array[position];
}

void printList(ListArray *list)
{
	for (int temp = 0; temp != last(list); temp++)
	{
		std::cout << list->array[temp] << " ";
	}
	std::cout << std::endl; 
}

void deleteList(ListArray *list)
{
	delete list->array;
	delete list;
}