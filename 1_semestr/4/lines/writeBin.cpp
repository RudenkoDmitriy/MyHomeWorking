#include "writeBin.h"
#include <iostream>

//Выводит на экран представление числа в двоичном виде. 
//На вход подается булевый массив.

void myWork::writeBin(bool binary[]) 
{
	for (int i = 0; i < sizeof(short int) * 8; i++)
	{
		std::cout << binary[i];
	}
}