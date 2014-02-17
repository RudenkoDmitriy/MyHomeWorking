#pragma once
#include <stdio.h>
#include <iostream>

struct ListArray;

typedef int TypeOfValue;
typedef int TypeOfSize;

//Create a new empty list.
//"Test" in the input is mask on constructor.
ListArray *createList(int test);

//Delete list.
void deleteList(ListArray *list);

//Return position of head element of list.
int head(ListArray *list);
//Return position of first meaning element of list.
int firstElement(ListArray *list);
//Return position of last element of list.
int last(ListArray *list);
//Return position of next element about input position.
int next(ListArray *list, int position);
//Return position of middle element.
int middle(ListArray *list);
//Return length of list.
TypeOfSize length(ListArray *list);
//Return position about input value.
int returnPos(ListArray *list, TypeOfValue value);
//Return value about input position.
TypeOfValue returnByPos(ListArray *list, int position);

//Enter all elements of list.
void printList(ListArray *list);
//Remove element in list about input position.
void remove(ListArray *list, int position);
//Insert element in input position.
void insert(ListArray *list, TypeOfValue value, int position);
//Copy element to list in input positon.
void copy(ListArray *list, TypeOfValue value, int position);

//Change value about position to input value.
void changeValue(ListArray *list, int position, TypeOfValue value);