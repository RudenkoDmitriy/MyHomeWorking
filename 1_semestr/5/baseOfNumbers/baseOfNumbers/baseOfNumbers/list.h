#include <stdio.h>
#include <iostream>
const int max = 100;

struct Record
{
	std::string name;
	std::string number;
};

struct List;

typedef std::string TypeOfRecord;
typedef int Position;
typedef Record *PositionOfElement;

//Create new empty list.
List *createList();

//Return position of first element of list.
Position head(List *list);
//Return position of last element of list.
Position end(List *list);
//Return position of next element about input position.
Position next(List *list, Position position);
//Return position of previous element about input position.
Position previous(List *list, Position position);
//Return record in base about position.
PositionOfElement returnRecordByPos(List *list, Position position);

//Insert element in list on input position.
void insert(List *list, PositionOfElement element, Position position);
//Print all element of list.
void print(List *list);
//Delete list.
void deleteList(List *list);
