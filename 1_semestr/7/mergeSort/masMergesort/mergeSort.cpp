#include <stdio.h>
#include <iostream>
#include "mergesort.h"

List *mergesort(List *list)
{
	if (length(list) == 1)
	{
		return list;
	}
	Position testOnConstr = NULL;
	bool test = 0;
	List *leftHalf = createList(testOnConstr);
	List *rightHalf = createList(testOnConstr);
	Position posLeft = head(leftHalf);
	Position posRight = head(rightHalf);
	for (Position temp = firstElement(list); temp != next(list, middle(list)); temp = next(list, temp))
	{
		insert(leftHalf, returnByPos(list, temp), posLeft);
		posLeft = next(leftHalf, posLeft);
	}
	for (Position temp = next(list, middle(list)); temp != last(list); temp = next(list, temp))
	{
		insert(rightHalf, returnByPos(list, temp), posRight);
		posRight = next(rightHalf, posRight);
	}
	leftHalf = mergesort(leftHalf);
	rightHalf = mergesort(rightHalf);
	List *result = createList(testOnConstr);
	Position posResult = head(result);
	posLeft = head(leftHalf);
	posRight = head(rightHalf);
	while (length(leftHalf) && length(rightHalf) != 0)
	{
		if (returnByPos(leftHalf, firstElement(leftHalf)) <= returnByPos(rightHalf, firstElement(rightHalf)))
		{
			insert(result, returnByPos(leftHalf, firstElement(leftHalf)), posResult);
			remove(leftHalf, posLeft);
			posResult = next(result, posResult);
		}
		else
		{
			insert(result, returnByPos(rightHalf, firstElement(rightHalf)), posResult);
			remove(rightHalf, posRight);
			posResult = next(result, posResult);
		}
	}
	while (length(leftHalf) != 0)
	{
		insert(result, returnByPos(leftHalf, firstElement(leftHalf)), posResult);
		remove(leftHalf, posLeft);
		posResult = next(result, posResult);
	}
	while (length(rightHalf) != 0)
	{
		insert(result, returnByPos(rightHalf, firstElement(rightHalf)), posResult);
		remove(rightHalf, posRight);
		posResult = next(result, posResult);
	}
	deleteList(leftHalf);
	deleteList(rightHalf);
	return result;
}