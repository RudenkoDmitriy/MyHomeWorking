#include <stdio.h>
#include <iostream>
#include "stack.h"

struct ElementOfStack
{
	ValueType value;
	ElementOfStack *next;
};

struct Stack
{
	ElementOfStack *head;
	SizeType size;
};

Stack *createNewStack()
{
	Stack *result = new Stack;
	result->size = 0;
	result->head = nullptr;
	return result;
};

SizeType size(Stack *stack)
{
	return stack->size;
}

ValueType top(Stack *stack, bool &test)
{
	if (stack->size != 0)
	{
		return stack->head->value;
	}
	else
	{
		printf("Error: stack is empty\n");
		test = true;
		return -99999;
	}
}

void push(Stack *stack, const ValueType value)
{
	ElementOfStack *newElement = new ElementOfStack;
	newElement->value = value;
	newElement->next = stack->head;
	stack->head = newElement;
	stack->size++;
}

void pop(Stack *stack, bool &test)
{
	if (stack->size != 0)
	{
		Position temp = stack->head;
		stack->head = stack->head->next;
		stack->size--;
		delete temp;
	}
	else
	{
		printf("Stack is empty\n");
		test = 1;
	}
}

void deleteStack(Stack *stack)
{
	bool test = false;
	while (stack->head != nullptr)
	{
		pop(stack, test);
	}
	if (test)
	{
		printf("Error");
	}
	delete stack;
}
