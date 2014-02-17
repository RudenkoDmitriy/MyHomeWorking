#include "list.h"
#include <stdio.h>
#include <iostream>
#include <fstream>
#include <string>

struct List
{
	PositionOfElement baseOfRecord[max];
	Position last;
};

List *createList()
{
	List *list = new List;
	for (Position temp = 0; temp != max; temp++)
	{
		list->baseOfRecord[temp] = nullptr;
	}
	list->last = -1;
	return list;
}

Position head(List *list)
{
	return 0;
}

Position end(List *list)
{
	return list->last + 1;
}

Position previous(List *list, Position position)
{
	return position - 1;
}

Position next(List *list, Position position)
{
	return position + 1;
}

void insert(List *list, PositionOfElement element, Position position)
{
	if (list->last < max - 1)
	{
		list->baseOfRecord[end(list)] = element;
		list->last++;
	}
	else 
	{
		std::cout << "Base is full" << std::endl;
	}
}

PositionOfElement returnRecordByPos(List *list, Position position)
{
	return list->baseOfRecord[position];
}

void print(List *list)
{
	for (Position temp = 0; temp != end(list); temp++)
	{
		std::cout << list->baseOfRecord[temp]->name << " " << list->baseOfRecord[temp]->number;
		std::cout << std::endl;
	}
}

void deleteList(List *list)
{
	for (Position temp = 0; temp != max - 1; temp++)
	{
		delete list->baseOfRecord[temp];
	}
	delete list;
}