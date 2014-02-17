#include <stdio.h> 
#include <iostream>

using namespace std;
 
int main()
{   
	cout << "Enter value of x:" << endl;
	int x = 0;
	cin >> x;
	int squareOfX = x * x;
	cout << "Vot otvet:" << endl << (squareOfX + 1) * (squareOfX + x) << endl;
	return 0;
}