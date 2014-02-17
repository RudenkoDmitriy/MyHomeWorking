#include <stdio.h>
#include <iostream>
#include <string>
#include "list.h"

struct Record;

//Create a new element of base of number.
Record *createNewElement(std::string name, std::string number);
//Save data in list to file. Input is name of file.
void saveToFile(List *list, std::string nameOfFile);
//Read data from file to list. Input is name if file.
void readFromFile(List *list, std::string nameOfFile);

//Return number about input name.
TypeOfRecord returnNumberByName(List *list, TypeOfRecord name);
//Return name about input number.
TypeOfRecord returnNameByNumber(List *list, TypeOfRecord number);