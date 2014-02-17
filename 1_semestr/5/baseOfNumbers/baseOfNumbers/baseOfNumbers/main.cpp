#include <stdio.h>
#include <iostream>
#include <fstream>
#include <string>
#include "baseOfNumbers.h"

//Function create a new list, consisting of numbers and owners.
//First data is reading from text file, whose name is entered by the user.
//Operation with list:
//0 - escape;
//1 - insert resord;
//2 - seaching number in list by name;
//3 - serching name in list by number;
//4 - save all records in text file.

//Testing by file "text.txt" is positive.
//By assumption, given that the records in the file is not larger than the specified size of the array.
//Data in text file can be write as:
//<Name of owner1>(space)<Number1>
//<Name of owner2>(space)<Number2>

int main()
{
	List *list = createList();
	std::string nameOfFile;
	std::cout << "Enter the name of file" << std::endl;
	std::cin >> nameOfFile;
	readFromFile(list, nameOfFile);
	int numberOfOperation = 1;
	std::string name = "";
	std::string number = "";
	std::cout << "Operation with list:" << std::endl;
	std::cout << "0 - escape;" << std::endl;
	std::cout << "1 - insert record;" << std::endl;
	std::cout << "2 - seaching number in list by name;" << std::endl;
	std::cout << "3 - serching name in list by number;" << std::endl;
	std::cout << "4 - save all records in text file." << std::endl;
	while (numberOfOperation)
	{
		std::cout << "Enter the number of operation" << std::endl;
		std::cin >> numberOfOperation;
		switch (numberOfOperation)
		{
		case 1:
			{
				std::cout << "Enter the name of man" << std::endl;
				std::cin >> name;
				std::cout << "Enter the number" << std::endl;
				std::cin >> number;
				Record *element = createNewElement(name,number); 
				insert(list, element, end(list));
				break;
			}
		case 2:
			{
				std::cout << "Enter the name of man" << std::endl;
				std::cin >> name;
				std::cout << returnNumberByName(list, name) << std::endl;
				break;
			}
		case 3:
			{
				std::cout << "Enter the number" << std::endl;
				std::cin >> number;
				std::cout << returnNameByNumber(list, number) << std::endl;
				break;
			}
		case 4:
			{
				saveToFile(list, nameOfFile);
				break;
			}
		case 0:
			{
				break;
			}
		default:
			{
				std::cout << "Incorrect value" << std::endl;
				break;
			}
		}
	}
	print(list);
	deleteList(list);
	return 0;
}