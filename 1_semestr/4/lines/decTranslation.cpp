#include "decTranslation.h"
#include <stdio.h>
#include <iostream>
#include <math.h>

//Переводит двоичное представление числа в десятичное.
//Адаптирована под сумму в которой 0-ой элемент выполняет значение контроля за переполнением.
//На вход получет бинарный массив и десятичное число.
//Возвращае десятичное значение числа.

short int myWork::decTranslation(bool binary[])
{
	short int decimal = 0;
	for (int i = 1; i <= sizeof(short int) * 8; i++)
	{
		decimal += binary[i] * pow(2, sizeof(short int) * 8 - i);
	}
	return decimal;
}