#include "writeBin.h"
#include <iostream>

//������� �� ����� ������������� ����� � �������� ����. 
//�� ���� �������� ������� ������.

void myWork::writeBin(bool binary[]) 
{
	for (int i = 0; i < sizeof(short int) * 8; i++)
	{
		std::cout << binary[i];
	}
}