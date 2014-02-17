#pragma once
#include <stdio.h>
#include <iostream>

struct ElementOfList;
struct ListPoint;

typedef int TypeOfSize;
typedef int TypeOfValue;

//Create a new empty list.
//"Test" in the input is mask on constructor.
ListPoint *createList(ElementOfList *test);

//Return position of head element of list.
ElementOfList *head(ListPoint *list);
//Return position of first meaning element of list.
ElementOfList *firstElement(ListPoint *list);
//Return position of last element of list.
ElementOfList *last(ListPoint *list);
//Return position of next element about input position.
ElementOfList *next(ListPoint *list, ElementOfList *position);
//Return value about input position.
TypeOfValue returnByPos(ListPoint *list, ElementOfList *position);

//Enter all elements of list.
void printList(ListPoint *list);
//Remove element in list about input position.
void remove(ListPoint *list, ElementOfList *position);
//Insert element in input position.
void insert(ListPoint *list, TypeOfValue value, ElementOfList *position);
//Copy element from one list to over.
void copy(ListPoint *list, TypeOfValue value, ElementOfList *position);

//Change value about position to input value.
void changeValue(ListPoint *list, ElementOfList *position, TypeOfValue value);
//Delete  list.
void deleteList(ListPoint *list);
//Return position of middle element.
ElementOfList *middle(ListPoint *list);
//Return length of list.
TypeOfSize length(ListPoint *list);