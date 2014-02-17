#include <stdio.h>
#include <iostream>
#include "deckster.h"
#include "brackets.h"
#include "calculateStack.h"

using namespace std;

//Function translates the ordinary expression to postfix.
//Input is ordinary expression.
//Output is postfix expression.
//Test is possitive with expression "(3 + (5 * 4)) * (1 + (7 * 8))
int main()
{
	Stack *stack = createNewStack();
	char *expression = new char[255];
	cout << "Enter expression" << endl;
	gets_s(expression, 255);
	bool test = false;
	bool control = brackets(stack, expression, test);
	if (!control)
	{
		cout << "Error" << endl;
		delete expression;
		deleteStack(stack);
		return 0;
	}
	else
	{
		int controlOfSize = 0;
		expression = deckster(stack, expression, controlOfSize, test);
		if (test)
		{
			cout << "Error" << endl;
			deleteStack(stack);
			return 0;
		}
		cout << "Postfix expression: ";
		for (int i = 0; i != controlOfSize; i++)
		{
			cout << expression[i] << " ";
		}
		cout << endl;
		cout << "Computing solution: ";
		cout << calculate(stack, expression, test) << endl;
		deleteStack(stack);
		return 0;
	}
}