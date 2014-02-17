#include "binTranslation.h"

//��������� ����� �� ���������� � ��������. �������� �� ���� ������� ������ � ����� � ���������� �������.
// ���������� ������� ������, �������������� �� ���� �������� ������������� ����������� �����.

void myWork::binTranslation(bool binary[], short int decimal) 
{
	short int mask = 1;
	for (int i = sizeof(short int) * 8 - 1; i >= 0; i--)
	{
		binary[i] = (decimal & mask) != 0;
		mask = mask << 1;
	}
}
