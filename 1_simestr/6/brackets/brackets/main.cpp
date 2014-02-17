#include <stdio.h>
#include <string>
#include <iostream>
#include "brackets.h"

//Function checks nesting of bracket.
//Input is exression with or without brackets.
//Output is result of cheking.
//Test is positiv with line: ({[]})
int main()
{
	Stack *stack = createNewStack();
	char expression[255];
	std::cout << "Enter expression" << std::endl;
	gets_s(expression, 255);
	bool test = false;
	bool correct = brackets(stack, expression, test);
	if (!test)
	{
		if (correct)
		{
			std::cout << "All right" << std::endl;
		}
		else
		{
			std::cout << "Error" << std::endl;
		}
	}
	deleteStack(stack);
	return 0;
}