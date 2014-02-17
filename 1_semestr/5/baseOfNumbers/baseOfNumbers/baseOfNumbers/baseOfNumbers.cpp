#include <stdio.h>
#include <iostream>
#include <fstream>
#include <string>
#include "baseOfNumbers.h"

Record *createNewElement(std::string name, std::string number)
{
	Record *element = new Record;
	element->name = name;
	element->number = number;
	return element;
}

void saveToFile(List *list, std::string nameOfFile)
{
	std::ofstream text(nameOfFile);
	for (Position temp = 0; temp != end(list); temp++)
	{
		text << returnRecordByPos(list, temp)->name << " " << returnRecordByPos(list, temp)->number << std::endl; 
	}
	text.close();
}

void readFromFile(List *list, std::string nameOfFile)
{
	std::ifstream text(nameOfFile);
	if (text)
	{
		TypeOfRecord name  = "";
		TypeOfRecord number  = "";
		while (!text.eof())
		{
			text >> name;
			text >> number;
			if (name != "" && number != "")
			{
				Record *element = createNewElement(name, number);
				insert(list, element, end(list));
			}
			name.clear();
			number.clear();
		}
		text.close();
	}
}

TypeOfRecord returnNumberByName(List *list, TypeOfRecord name)
{
	for (Position temp = 0; temp != end(list); temp = next(list, temp))
	{
		if (strcmp(returnRecordByPos(list, temp)->name.c_str(), name.c_str()) == 0)
		{
			return "Number of man is " + returnRecordByPos(list, temp)->number;
		}
	}
	return "Name didn't find";
}

TypeOfRecord returnNameByNumber(List *list, TypeOfRecord number)
{
	for (Position temp = 0; temp != max; temp++)
	{
		if (strcmp(returnRecordByPos(list, temp)->number.c_str(), number.c_str()) == 0)
		{
			return "Name of owner is " + returnRecordByPos(list, temp)->name;
		}
	}
	return "Number did'n find";
}