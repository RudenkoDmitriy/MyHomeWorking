#include "deckster.h"

char *deckster(Stack *stack, char line[], int &controlOfSize, bool &test)
{
	char *result = new char[255];
	int lastInResult = 0;
	for (int  i = 0; line[i] != '\0'; i++)
	{
		if (line[i] >= '0' && line[i] <= '9')
		{
			result[lastInResult] = line[i];
			lastInResult++;
			continue;
		}
		if (line[i] == '+' || line[i] == '-')
		{
			if (size(stack) != 0)
			{
				while (size(stack) != 0 && (top(stack, test) == '*' || top(stack, test) == '/' || top(stack, test) == '+' || top(stack, test) == '-'))
				{
					result[lastInResult] = top(stack, test);
					lastInResult++;
					pop(stack, test);
				}
			}
			push(stack, line[i]);
		}
		if (line[i] == '*' || line[i] == '/')
		{
			if (size(stack) != 0)
			{
				while (size(stack) != 0 && (top(stack, test) == '*' || top(stack, test) == '/'))
				{
					result[lastInResult] = top(stack, test);
					lastInResult++;
					pop(stack, test);
				}
			}
			push(stack, line[i]);
		}
		if (line[i] == '(')
		{
			push(stack, line[i]);
		}
		if (line[i] == ')')
		{
			while (top(stack, test) != '(')
			{
				result[lastInResult] = top(stack, test);
				lastInResult++;
				pop(stack, test);
			}
			pop(stack, test);
			if (size(stack) != 0)
			{
				if (top(stack, test) == '+' || top(stack, test) == '-' || top(stack, test) == '*' || top(stack, test) == '/')
				{
					result[lastInResult] = top(stack, test);
					lastInResult++;
					pop(stack, test);
				}
			}
		}
	}
	while (size(stack) != 0)
	{
		result[lastInResult] = top(stack, test);
		lastInResult++;
		pop(stack, test);
	}
	controlOfSize = lastInResult;
	delete []line;
	return result;
}