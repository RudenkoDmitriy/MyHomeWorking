#include "add.h"
#include "binTranslation.h"
#include "decTranslation.h"
#include "writeBin.h"
#include "writeBinAmount.h"
#include <stdio.h>
#include <iostream>
#include <math.h>

using namespace std;

// ������������� ��� ����� �����.
// ����� ��������� �� ����� �� �������� ������������� � ������������� �� ����� � �������� � ���������� ����.
// �������� ������ - (2;3). ��������� ���� - (2,3; 3). ����������� ������ - (-2;3),(2;-3)

int main()
{
	setlocale(LC_ALL, "Russian");
	short int firstValue = 0;
	cout << "������� ������ �����" << endl;
	cin >> firstValue;
	short int secondValue = 0;
	cout << "������� ������ �����" << endl;
	cin >> secondValue;
	bool binFirst[sizeof(short int) * 8] = {0};
	myWork::binTranslation(binFirst, firstValue);
	cout << "�������� ������������� ����� " << firstValue << "=";
	myWork::writeBin(binFirst);
	bool binSecond[sizeof(short int) * 8] = {0};
	myWork::binTranslation(binSecond, secondValue);
	cout << endl << "�������� ������������� ����� " << secondValue << "=";
	myWork::writeBin(binSecond);
	//����� ���������� � ������� ������ �������� �� ���� ������, ��� ������������. (������ �������-������ �� ������������).
	bool amount[sizeof(short int) * 8 + 1] = {0}; 
	myWork::add(amount, binFirst, binSecond);
	cout << endl << "�� ����� � �������� ����=";
	myWork::writeBinAmount(amount);
	short int decAmount = 0;
	decAmount = myWork::decTranslation(amount);
	cout << endl << "�� ����� � ���������� ����=" << decAmount << endl;
	return 0;
}
