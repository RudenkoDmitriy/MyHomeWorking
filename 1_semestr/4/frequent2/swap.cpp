#include "swap.h"

void myWork::swap(int &value1, int &value2)
{
	int temp = value1;
	value1 = value2;
	value2 = temp;
}