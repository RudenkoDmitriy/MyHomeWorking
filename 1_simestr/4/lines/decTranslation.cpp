#include "decTranslation.h"
#include <stdio.h>
#include <iostream>
#include <math.h>

//��������� �������� ������������� ����� � ����������.
//������������ ��� ����� � ������� 0-�� ������� ��������� �������� �������� �� �������������.
//�� ���� ������� �������� ������ � ���������� �����.
//��������� ���������� �������� �����.

short int myWork::decTranslation(bool binary[])
{
	short int decimal = 0;
	for (int i = 1; i <= sizeof(short int) * 8; i++)
	{
		decimal += binary[i] * pow(2, sizeof(short int) * 8 - i);
	}
	return decimal;
}