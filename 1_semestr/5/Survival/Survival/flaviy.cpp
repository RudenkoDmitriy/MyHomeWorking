#include "circleList.h"
#include "flaviy.h"

TypeOfValue flaviy(List *list, TypeOfValue period, TypeOfValue numberOfWarriors)
{
	int countOfIteration = 0;
	Position positionOfIteration = head(list);
	while (numberOfWarriors > 1)
	{
		countOfIteration++;
		if (countOfIteration % period == 0)
		{
			numberOfWarriors--;
			Position temp = positionOfIteration;
			positionOfIteration = next(list, temp);
			remove(list, temp);
		}
		else 
		{
			positionOfIteration = next(list, positionOfIteration);
		}
	}
	return returnByPos(list, head(list));
}