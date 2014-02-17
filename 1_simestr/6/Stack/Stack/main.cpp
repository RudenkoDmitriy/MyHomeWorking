#include <stdio.h>
#include <stdlib.h>
#include <string>
#include <iostream>
#include "calculateStack.h"

//Function calculates the arithmetic expression in postfix notation.
//Input is postfix notation.
//Output is calculated value.
//Test if positive with line: 96-12+*.(output 9) and 90/12+*(output "Error: divide by ZeRo!!")
//Test is negative with line: 96-12+*3(output 3)
int main()
{
	char postfixNotation[255];
	std::cout << "Enter postfix notation" << std::endl;
	gets_s(postfixNotation, 255);
	Stack *stack = createNewStack();
	bool test = 0;
	int result = calculate(stack, postfixNotation, test);
	if (!test)
	{
		std::cout << "Result: " << calculate(stack, postfixNotation, test) << std::endl;
	}
	deleteStack(stack);
	return 0;
}