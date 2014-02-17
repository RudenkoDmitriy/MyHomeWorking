#pragma once;
struct NodeOfTree;

typedef int TypeOfKey;
typedef NodeOfTree BinTree;

//Create empty binary tree.
NodeOfTree *createTree();
//Add value in binary tree.
NodeOfTree *add_tree(NodeOfTree *root, TypeOfKey key);
//Function check exist input value in binary tree.
bool existKey(NodeOfTree *root, TypeOfKey key);
//Remove value from binary tree.
NodeOfTree *removeKey(NodeOfTree *root, TypeOfKey key);
//Print tree's values in ascending order.
void printInAscending(NodeOfTree *mainRoot);
//Print tree's values in decreasing order.
void printInDecreasing(NodeOfTree *mainRoot);
//Delete binary tree.
void deleteBinTree(NodeOfTree *root);