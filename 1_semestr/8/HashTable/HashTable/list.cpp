#include <stdio.h>
#include <iostream>
#include <string>
#include "List.h"

struct ElementOfList
{
	TypeOfValue value;
	ElementOfList *next;
};

struct List
{
	ElementOfList *head;
};

void swap(int &value1, int &value2)
{
	int temp = value1;
	value1 = value2;
	value2 = temp;
}

List *createList()
{
	List *result = new List;
	result->head = nullptr;
	return result;
}

TypeOfElement *createNewElement()
{
	TypeOfElement *element = new TypeOfElement;
	element->word = "";
	element->countOfWord = 0;
	return element;
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
	return list->head;
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

Position returnPos(List* list, TypeOfWord word)
{
	for (Position temp = head(list); temp != nullptr; temp = next(list, temp))
	{
		if (temp->value->word == word)
		{
			return temp;
		}
	}
	return list->head;
}

void insert(List *list, TypeOfWord word)
{
	if (existInList(list, word))
	{
		returnPos(list, word)->value->countOfWord++;
	}
	else
	{
		ElementOfList *element = new ElementOfList;
		element->value = createNewElement();
		element->value->word = word;
		element->value->countOfWord = 1;
		element->next = list->head;
		list->head = element;
	}
}

bool existInList(List *list, TypeOfWord word)
{
	for (Position position = list->head; position != nullptr; position = position->next)
	{
		if (position->value->word == word)
		{
			return true;
		}
	}
	return false;
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

void printList(List *list, int maxSizeOfWord)
{
	if (list->head != nullptr)
	{
		Position temp = head(list);
		while (temp != nullptr)
		{
			std::cout << temp->value->word;
			int tabulation = maxSizeOfWord - temp->value->word.size();
			for (int i = 0; i != tabulation; i++)
			{
				std::cout << " ";
			}
			std::cout << temp->value->countOfWord << std::endl;
			temp = temp->next;
		}
	}
}

void deleteList(List *list)
{
	Position position = list->head;
	while (position != nullptr)
	{
		Position temp = position;
		position = position->next;
		delete temp;
	}
	delete list;
}