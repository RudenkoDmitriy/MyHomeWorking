#pragma once;
#include <string>;

typedef std::string TypeOfWord; 

struct HashTable;
//Create new hash-table.
HashTable *createHashTable();
//Delete hash-table.
void deleteHashTable(HashTable *table);

//Insert element to hash-table.
void insertHashTable(HashTable *table, TypeOfWord word);
//Remove element from hash-table.
void removeHashElement(HashTable *table, TypeOfWord word);
//Cheack avialability in hash-table.
bool existHashElement(HashTable *table, TypeOfWord word);
//Print element in hash-table.
//Input maximum of words' element for tabulation.
void printHashTable(HashTable *table, int maxSizeOfWord);