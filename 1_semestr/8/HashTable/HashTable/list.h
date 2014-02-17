#pragma once;
#include <stdio.h>
#include <iostream>

struct ElementOfList;
struct List;

struct TypeOfElement
{
	int countOfWord;
	std::string word;
};

typedef ElementOfList *Position;
typedef TypeOfElement *TypeOfValue;
typedef std::string TypeOfWord; 

//Interchange the elements in the cells.
void swap(int &value1, int &value2);

//Create a new empty list.
List *createList();
//Delete list.
void deleteList(List *list);

//Return position of first element of list.
Position head(List *list);
//Return position of last element of list.
Position last(List *list);
//Return position of next element about input position.
Position next(List *list, Position position);
//Return position of previous element about input position.
Position previous(List *list, Position position);
//Return position about input value.
Position returnPos(List* list, TypeOfWord word);

//Enter all elements of list.
//Input maximum of words' element for tabulation.
void printList(List *list, int maxSizeOfWord);
//Remove element in list about input position.
void remove(List*list, Position position);
//Insert element in input position.
void insert(List *list, TypeOfWord value);

//Check availability in list.
bool existInList(List *list, std::string word);