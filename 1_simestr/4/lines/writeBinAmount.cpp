#include "writeBinAmount.h"
#include <iostream>

//������� WriteBin, �������������� ��� �����.

void myWork::writeBinAmount(bool binary[])
{
	for(int i = 1; i < sizeof(short int) * 8 + 1; i++)
	{
		std::cout << binary[i];
	}
}