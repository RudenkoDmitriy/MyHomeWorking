#include "binTranslation.h"

//ѕереводит число из дес€тичной в двоичную. ѕолучает на вход булевый массив и число в дес€тичной системе.
// ¬озвращает булевый массив, представл€ющий из себ€ двоичное представление дес€тичного числа.

void myWork::binTranslation(bool binary[], short int decimal) 
{
	short int mask = 1;
	for (int i = sizeof(short int) * 8 - 1; i >= 0; i--)
	{
		binary[i] = (decimal & mask) != 0;
		mask = mask << 1;
	}
}
