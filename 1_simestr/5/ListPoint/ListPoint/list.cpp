#include <stdio.h>
#include <iostream>
#include "List.h"

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

Position head(List *list)
{
	return list->head;
}

Position last(List *list)
{
	return nullptr;
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
		list->head = position->next;
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