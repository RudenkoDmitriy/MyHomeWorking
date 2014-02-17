#include "brackets.h"

bool brackets(Stack *stack, char *line, bool &test)
{
	for (int i = 0; line[i] != '\0'; i++)
	{
		char symbol = line[i];
		if (symbol != '('  && symbol != '{' && symbol != '[' && symbol != ']'  && symbol != '}' &&  symbol != ')' )
		{
			continue;
		}
		if (symbol == '('  || symbol == '{' ||  symbol == '[' )
		{
			push(stack, symbol);
			continue;
		}
		if (size(stack) == 0)
		{
			return false;
		}
		if (symbol == ')')
		{
			if (top(stack, test) == '(')
			{
				pop(stack, test);
				continue;
			}
			else 
			{
				return false;
			}
		}
		if (symbol == '}')
		{
			if (top(stack, test) == '{')
			{
				pop(stack, test);
				continue;
			}
			else 
			{
				return false;
			}
		}
		if (symbol == ']')
		{
			if (top(stack, test) == '[')
			{
				pop(stack, test);
				continue;
			}
			else 
			{
				return false;
			}
		}
	}
	return size(stack) == 0;
}
