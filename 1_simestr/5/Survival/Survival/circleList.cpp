#include <stdio.h>
#include <iostream>
#include "circleList.h"

struct ElementOfList
{
	int value;
	ElementOfList *next;
};

struct List
{
	ElementOfList *head;
};

List *createList()
{
	List *result = new List;
	result->head = nullptr;
	return result;
}

void createCircularList(List *list)
{
	last(list)->next = head(list);
}

Position head(List *list)
{
	return list->head;
}

Position last(List *list)
{
	for (Position temp = head(list); temp != nullptr; temp = next(list, temp))
	{
		if (temp->next == nullptr)
		{
			return temp;
		}
	}
}

Position next(List *list, Position position)
{
	return position->next;
}

Position previous(List *list, Position position)
{
	Position temp = head(list);
	while (next(list, temp) != position)
	{
		temp = temp->next;
	}
	return temp;
}

Position returnPos(List* list, TypeOfValue value)
{
	for (Position temp = head(list); temp != nullptr; temp = next(list, temp))
	{
		if (temp->value == value)
		{
			return temp;
		}
	}
	return nullptr;
}

TypeOfValue returnByPos(List *list, Position position)
{
	return position->value;
}

void insert(List *list, TypeOfValue value, Position position)
{
	ElementOfList *element = new ElementOfList;
	element->value = value;
	element->next = position->next;
	position->next = element;
}

void insertToHead(List *list, TypeOfValue value)
{
	ElementOfList *element = new ElementOfList;
	element->value = value;
	element->next = list->head;
	list->head = element;
}

void changeValue(List *list, Position position, TypeOfValue value)
{
	position->value = value;
}

void remove(List*list, Position position)
{
	if (position == nullptr)
	{
		std::cout << "Error" << std::endl;
		return;
	}
	if (position == head(list))
	{
		previous(list,head(list))->next = position->next;
		list->head = position->next;
		delete position;
		return;
	}
	Position temp = previous(list, position);
	temp->next = position->next;
	delete position;
}

void print(List *list)
{
	Position temp = head(list);
	while (temp != nullptr)
	{
		std::cout << temp->value << " ";
		temp = temp->next;
	}
	std::cout << std::endl;
}

void deleteList(List *list)
{
	Position temp = head(list);
	while (temp != nullptr)
	{
		Position tempToRemove = temp;
		temp = next(list, temp);
		remove(list, tempToRemove);
	}
	delete list;
}

void deleteCircleList(List *list)
{
	Position temp = next(list, head(list));
	while (temp != head(list))
	{
		Position tempToRemove = temp;
		temp = next(list, temp);
		remove(list, tempToRemove);
	}
	remove(list, temp);
	delete list;
}
