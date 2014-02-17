#include "add.h"

//Складывает два числа, представленных в двоичном виде.
//На вход подается булевый массив суммы и два булевых массива с двоичными представлениями чисел. Возвращает булевый массив суммы со значением суммы.

void myWork::add(bool amount[], bool binFirst[], bool binSecond[]) 
{ 
	for (int i = sizeof(short int) * 8 ; i > 0; i--)
	{
		if (amount[i] + binFirst[i - 1] + binSecond[i - 1] == 2)
		{
			amount[i - 1]++;
			amount[i] = false;
		}
		else
			if (amount[i] + binFirst[i - 1] + binSecond[i - 1] == 3)
			{
				amount[i - 1]++;
				amount[i] = true;
			}
			else
				if (amount[i] + binFirst[i - 1] + binSecond[i - 1] == 1)
				{
					amount[i] = true;
				}
	}
}
