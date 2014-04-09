#include <stdio.h>
#include <iostream>
#include <string>
#include "listPoint.h"

struct ElementOfList
{
	TypeOfValue valu;
	ElementOfList *next;
};

struct ListPoint
{
	ElementOfList *head;
};

ListPoint *createList(ElementOfList *test)
{
	ListPoint *result = new ListPoint;
	ElementOfList *element = new ElementOfList;
	result->head = element;
	element->next = nullptr;
	return result;
}

ElementOfList *head(ListPoint *list)
{
	return list->head;
}

ElementOfList *firstElement(ListPoint *list)
{
	return list->head->next;
}

ElementOfList *last(ListPoint *list)
{
	return nullptr;
}

ElementOfList *next(ListPoint *list, ElementOfList *position)
{
	return position->next;
}

TypeOfValue returnByPos(ListPoint *list, ElementOfList *position)
{
	return position->value;
}

void insert(ListPoint *list, TypeOfValue value, ElementOfList *position)
{
	ElementOfList *element = new ElementOfList;
	element->value = value;
	element->next = position->next;
	position->next = element;
}

void copy(ListPoint *list, TypeOfValue value, ElementOfList *position)
{
	ElementOfList *element = new ElementOfList;
	element->value = value;
	element->next = position->next;
	position->next = element;
}

void changeValue(ListPoint *list, ElementOfList *position, TypeOfValue value)
{
	position->value = value;
}

void remove(ListPoint *list, ElementOfList *position)
{
	if (position == nullptr)
	{
		std::cout << "Error" << std::endl;
		return;
	}
	ElementOfList *temp = next(list, position);
	position->next = temp->next;
	delete temp;
}

void printList(ListPoint *list)
{
	ElementOfList *temp = firstElement(list);
	while (temp != nullptr)
	{
		std::cout << temp->value << " ";
		temp = temp->next;
	}
	std::cout << std::endl;
}

void deleteList(ListPoint *list)
{
	ElementOfList *temp = head(list);
	while (temp != nullptr)
	{
		ElementOfList *tempToRemove = temp;
		temp = next(list, temp);
		delete tempToRemove;
	}
	delete list;
}

int length(ListPoint *list)
{
	if (head(list) == 0)
	{
		return 0;
	}
	int count = 0;
	ElementOfList *temp = firstElement(list);
	while(temp != nullptr)
	{
		count++;
		temp = temp->next;
	}
	return count;
}

ElementOfList *middle(ListPoint *list)
{
	int middleCount = length(list) / 2 - 1;
	ElementOfList *temp = firstElement(list);
	while(middleCount > 0)
	{
		middleCount--;
		temp = temp->next;
	}
	return temp;
}