#include "List.h"
#include "hashTable.h"
#include <string>
#include <math.h>

const int sizeOfHashTable = 101;

struct HashTable
{
	List *buckets[sizeOfHashTable];
};

HashTable *createHashTable()
{
	HashTable *hashTable = new HashTable;
	for (int i = 0; i != sizeOfHashTable; i++)
	{
		hashTable->buckets[i] = createList();
	}
	return hashTable;
}

int hashFunction(TypeOfWord element)
{
	unsigned long int result = 0;
	for (int i = 0; i != element.size(); i++)
	{
		result +=element[i] * pow(101, i);
	}
	return result %= sizeOfHashTable;
}

void insertHashTable(HashTable *table, TypeOfWord word)
{
	if (word != "", word != " ", word != "\n", word != "\0")
	{
		insert(table->buckets[hashFunction(word)], word);
	}
	return;
}

void removeHashElement(HashTable *table, TypeOfWord word)
{
	remove(table->buckets[hashFunction(word)], returnPos(table->buckets[hashFunction(word)], word));
}

bool existHashElement(HashTable *table, TypeOfWord word)
{
	return existInList(table->buckets[hashFunction(word)], word);
}

void printHashTable(HashTable *table, int maxSizeOfWord)
{
	for (int i = 0; i != sizeOfHashTable; i++)
	{
		printList(table->buckets[i], maxSizeOfWord);
	}
}

void deleteHashTable(HashTable *table)
{
	for (int i = 0; i != sizeOfHashTable; i++)
	{
		deleteList(table->buckets[i]);
	}
	delete table;
}
