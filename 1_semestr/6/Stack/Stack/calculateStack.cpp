#include "calculateStack.h"

int calculate(Stack *stack, char *line, bool &test)
{
	for (int i = 0; line[i] != '\0'; i++)
	{
		char symbol = line[i];
		if (symbol != '-' && symbol != '*' && symbol != '/' && symbol != '+' && symbol != ' ')
		{
			push(stack, atoi(&symbol));
		}
		else switch (symbol)
		{
			case '+':
			{
				int result = 0;
				result += top(stack, test);
				pop(stack, test);
				result += top(stack, test);
				pop(stack, test);
				push(stack, result);
				break;
			}
			case '-':
			{
				int result = 0;
				result -= top(stack, test);
				pop(stack, test);
				result += top(stack, test);
				pop(stack, test);
				push(stack, result);
				break;
			}
			case '*':
			{
				int result = 0;
				result = 1;
				result *= top(stack, test);
				pop(stack, test);
				result *= top(stack, test);
				pop(stack,test);
				push(stack, result);
				break;
			}
			case '/':
			{
				if (top(stack, test) != 0)
				{
					int result = 0;
					int temp = top(stack, test);
					pop(stack, test);
					result = top(stack, test) / temp;
					pop(stack, test);
					push(stack, result);
					break;
				}
				else
				{
					printf("Error: divide by ZeRo!!\n");
					test = true;
					return -99999;
					break;
				}
			}
			default:
			{
				continue;
			}
		}
	}
	int result = top(stack, test);
	pop(stack, test);
	return result;
}