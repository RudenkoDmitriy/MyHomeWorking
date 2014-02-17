#pragma once;
#include <string>
struct NodeOfTree;

typedef char TypeOfKey;
typedef NodeOfTree BinTree;

//Create empty binary tree.
NodeOfTree *createTree();
//Delete binary tree.
void deleteBinTree(NodeOfTree *root);

//Add value in BST.
NodeOfTree *add_tree(NodeOfTree *root, TypeOfKey key);
//Function check exist input value in BST.
bool existKey(NodeOfTree *root, TypeOfKey key);
//Remove value from BST.
NodeOfTree *removeKey(NodeOfTree *root, TypeOfKey key);
//Print tree's values in ascending order.
void printInAscending(NodeOfTree *mainRoot);
//Print tree's values in decreasing order.
void printInDecreasing(NodeOfTree *mainRoot);

//Create arithmetic tree. Input is arithmetic expression.
NodeOfTree *createArithmTree(NodeOfTree *root, std::string line, int &position);
//Print arithmetic expression by arithmetic tree.
void printArithmTree(NodeOfTree *root);
//Count result of arithmetic expression by arithmetic tree.
//Input arithmetic tree and boolean variable.
//If division by ZeRo is in expression, fuction return in boolean variable true.
int countingArithmTree(NodeOfTree *root, bool &test);
