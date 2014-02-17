#include "hashTable.h"
#include <stdio.h>
#include <iostream>
#include <string>
#include <fstream>

using namespace std;

//Function counts words from file.
//Input file's name and file.
//Ouput number of words.
//Testing is positive with entered line "text.txt" and file "text.txt"

int main()
{
	setlocale(LC_ALL, "Russian");
	string nameOfFile;
	cout << "Enter the file's name" << endl;
	cin >> nameOfFile;
	ifstream text(nameOfFile);
	if (text)
	{
		HashTable *hashTable = createHashTable();
		int maxSizeOfWord = 0;
		text.seekg(3);
		while (!text.eof())
		{
			string word = "";
			text >> word;
			if (word.size() > maxSizeOfWord)
			{
				maxSizeOfWord = word.size();
			}
			insertHashTable(hashTable, word);
		}
		printHashTable(hashTable, maxSizeOfWord + 1);
		deleteHashTable(hashTable);
	}
	else
	{
		std::cout << "File don't exist" << endl;
	}
	return 0;
}