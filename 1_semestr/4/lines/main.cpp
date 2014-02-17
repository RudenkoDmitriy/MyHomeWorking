#include "add.h"
#include "binTranslation.h"
#include "decTranslation.h"
#include "writeBin.h"
#include "writeBinAmount.h"
#include <stdio.h>
#include <iostream>
#include <math.h>

using namespace std;

// Запрашиваются два целых числа.
// Затем выводится на экран их двоичное представление и представление их суммы в двоичном и десятичном виде.
// Типичный случай - (2;3). Ошибочный ввод - (2,3; 3). Пограничный случай - (-2;3),(2;-3)

int main()
{
	setlocale(LC_ALL, "Russian");
	short int firstValue = 0;
	cout << "Введите первое число" << endl;
	cin >> firstValue;
	short int secondValue = 0;
	cout << "Введите второе число" << endl;
	cin >> secondValue;
	bool binFirst[sizeof(short int) * 8] = {0};
	myWork::binTranslation(binFirst, firstValue);
	cout << "Двоичное представление числа " << firstValue << "=";
	myWork::writeBin(binFirst);
	bool binSecond[sizeof(short int) * 8] = {0};
	myWork::binTranslation(binSecond, secondValue);
	cout << endl << "Двоичное представление числа " << secondValue << "=";
	myWork::writeBin(binSecond);
	//Сумму записываем в булевый массив размеров на один больше, чем двухбайтовый. (Первый элемент-защита от переполнения).
	bool amount[sizeof(short int) * 8 + 1] = {0}; 
	myWork::add(amount, binFirst, binSecond);
	cout << endl << "Их сумма в двоичном виде=";
	myWork::writeBinAmount(amount);
	short int decAmount = 0;
	decAmount = myWork::decTranslation(amount);
	cout << endl << "Их сумма в десятичном виде=" << decAmount << endl;
	return 0;
}
