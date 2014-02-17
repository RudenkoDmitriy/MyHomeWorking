#include <stdio.h>
#include <iostream>

struct ElementOfList;
struct List;

typedef ElementOfList *Position;
typedef int TypeOfValue;

//Create a new empty list.
List *createList();

//Return position of first element of list.
Position head(List *list);
//Return position of last element of list.
Position last(List *list);
//Return position of next element about input position.
Position next(List *list, Position position);
//Return position of previous element about input position.
Position previous(List *list, Position position);
//Return position about input value.
Position returnPos(List* list, TypeOfValue value);
//Return value about input position.
TypeOfValue returnByPos(List *list, Position position);

//Enter all elements of list.
void print(List *list);
//Remove element in list about input position.
void remove(List*list, Position position);
//Insert element in input position.
void insert(List *list, TypeOfValue value, Position position);
//Insert element on first place in list.
void insertToHead(List *list, TypeOfValue value);
//Change value about position to input value.
void changeValue(List *list, Position position, TypeOfValue value);
//Delete ordinary list.
void deleteList(List *list);