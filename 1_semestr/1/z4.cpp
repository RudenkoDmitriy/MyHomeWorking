#include <stdio.h>
#include <iostream>
#include <math.h>

using namespace std;

int main()
{
	int div = 0;
	cout << "Enter divident" << endl;
	cin >> div;
	int mod = 0;
	cout << "Enter divisor" << endl;
	cin >> mod;
	int absoluteDiv = abs(div);
	int absoluteMod = abs(mod);
	int count = 0;
	while (absoluteDiv >= absoluteMod)
	{
		absoluteDiv = absoluteDiv - absoluteMod;
		count++;
	}
	if ((div < 0) && (mod < 0))
	{
		absoluteDiv = -absoluteDiv;
	}
	if ((div < 0) && (mod > 0))
	{
		count = -count;
		absoluteDiv = -absoluteDiv;
	}
	if ((div > 0) && (mod < 0))
	{
		count = -count;
	}
	cout << count << " ost " << absoluteDiv << endl;
	return 0;
}