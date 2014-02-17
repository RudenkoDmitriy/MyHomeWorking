#include <stdio.h>
#include <iostream>
#include "circleList.h"
#include "flaviy.h"

//Interchange value in input positions.  
void swap(List *list, Position temp, Position next)
{
	changeValue(list, temp, returnByPos(list, temp) ^ returnByPos(list, next));
	changeValue(list, next, returnByPos(list, temp) ^ returnByPos(list, next));
	changeValue(list, temp, returnByPos(list, temp) ^ returnByPos(list, next));
}

//Insert head element to sort list.
void insertHeadToSort(List* list)
{
	for (Position temp = head(list); next(list,temp) != nullptr && returnByPos(list, temp) > returnByPos(list, next(list,temp)); temp = next(list,temp))
	{
		swap(list, temp, next(list, temp));
	}
}

//Function find the number of place, where you can survive, if the people in the circle will be killed after a certain period.
//Number of people and period are input.
//Output is number of survival place.

//Testing by number of wars = 10 and period = 3 is positive.
//Testing by number of wars = 4.5 or "hk" and period = 4.1 or "io" is negative.

int main()
{
	List *list = createList();
	int numberOfWars = 0;
	std::cout << "Enter the number of wars" << std::endl;
	std::cin >> numberOfWars;
	int period = 0;
	std::cout << "Enter the period of murder" << std::endl;
	std::cin >> period;
	for (int i = 1; i <= numberOfWars; i++)
	{
		insertToHead(list, i);
		insertHeadToSort(list);
	}
	createCircularList(list);
	std::cout << "For survive should take the place in ranked at number " << flaviy(list, period, numberOfWars) << std::endl;
	deleteCircleList(list);
	return 0;
}