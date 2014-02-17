#include <stdio.h>
#include <iostream>
#include "binTree.h"

struct NodeOfTree
{
	TypeOfKey key;
	NodeOfTree *left;
	NodeOfTree *right;
};

NodeOfTree *createNode(TypeOfKey key)
{
	NodeOfTree *root = new NodeOfTree;
	root->key = key;
	root->left = nullptr;
	root->right = nullptr;
	return root;
}

NodeOfTree *createTree()
{
	return nullptr;
}

NodeOfTree *add_tree(NodeOfTree *root, TypeOfKey key)
{
	if (root == nullptr)
	{
		root = createNode(key);
	}
	if (key < root->key)
	{
		if (root->left == nullptr)
		{
			root->left = createNode(key);
		}
		else
		{
			add_tree(root->left, key);
		}
	}
	if (key > root->key)
	{
		if (root->right == nullptr)
		{
			root->right = createNode(key);
		}
		else
		{
			add_tree(root->right, key);
		}
	}
	return root;
}

NodeOfTree *findKey(NodeOfTree *root, TypeOfKey key)
{
	if (root->key == key)
	{
		return root;
	}
	if (key < root->key)
	{
		if (root->left == nullptr)
		{
			return nullptr;
		}
		return findKey(root->left, key);
	}
	if (key > root->key)
	{
		if (root->right == nullptr)
		{
			return nullptr;
		}
		return findKey(root->right, key);
	}
	return root;
}

bool existKey(NodeOfTree *root, TypeOfKey key)
{
	NodeOfTree *temp = root;
	while(root != nullptr)
	{
		if (root->key == key)
		{
			return true;
		}
		if (key < root->key)
		{
			if (root->left == nullptr)
			{
				return false;
			}
			temp = temp->left;
		}
		if (key > root->key)
		{
			if (root->left == nullptr)
			{
				return false;
			}
			temp = temp->right;
		}
	}
	return false;
}

NodeOfTree *parent(NodeOfTree *root, NodeOfTree *child)
{
	NodeOfTree *temp = root;
	while (temp->left != child  && temp->right != child)
	{
		if (child->key < temp->key)
		{
			temp = temp->left;
		}
		if (child->key > temp->key)
		{
			temp = temp->right;
		}
	}
	return temp;
}

NodeOfTree *rightMost(NodeOfTree *root)
{
	NodeOfTree *temp = root;
	while(root->right != nullptr)
	{
		root = root->right;
	}
	return root;
}

NodeOfTree *removeLeaf(NodeOfTree *mainRoot, NodeOfTree *leaf)
{
	if (leaf->left != nullptr && leaf->right == nullptr)
	{
		if (mainRoot == leaf)
		{
			mainRoot = leaf->left;
		}
		else
		{
			NodeOfTree *parentOfRoot = parent(mainRoot, leaf);
			if(leaf->left->key > parentOfRoot->key)
			{
				parentOfRoot->right = leaf->left;
			}
			else
			{
				parentOfRoot->left = leaf->left;
			}
		}
	}
	if (leaf->left == nullptr && leaf->right != nullptr)
	{
		if (mainRoot == leaf)
		{
			mainRoot = leaf->right;
		}
		else
		{
			NodeOfTree *parentOfRoot = parent(mainRoot, leaf);
			if(leaf->right->key > parentOfRoot->key)
			{
				parentOfRoot->right = leaf->right;
			}
			else
			{
				parentOfRoot->left = leaf->right;
			}
		}
	}
	if (leaf->left == nullptr && leaf->right == nullptr)
	{
		if (mainRoot == leaf)
		{
			mainRoot = nullptr;
		}
		else
		{
			NodeOfTree *parentOfRoot = parent(mainRoot, leaf);
			parentOfRoot->left = nullptr;
			parentOfRoot->right = nullptr;
		}
	}
	delete leaf;
	return mainRoot;
}

NodeOfTree *removeKey(NodeOfTree *root, TypeOfKey key)
{
	NodeOfTree *nodeWithKey = findKey(root, key);
	if (nullptr == nodeWithKey)
	{
		return root; 
	}
	if ((nodeWithKey->left == nullptr && nodeWithKey->right == nullptr) || (nodeWithKey->left != nullptr && nodeWithKey->right == nullptr) || (nodeWithKey->left == nullptr && nodeWithKey->right != nullptr))
	{
		root = removeLeaf(root, nodeWithKey);
		return root;
	}
	if (nodeWithKey->left != nullptr && nodeWithKey->right != nullptr)
	{
		NodeOfTree *temp = rightMost(nodeWithKey);
		TypeOfKey tempOfKey = temp->key;
		root = removeLeaf(root, temp);
		nodeWithKey->key = tempOfKey;
		return root;
	}
	return root;
}

void printInAscending(NodeOfTree *mainRoot)
{
	if (mainRoot != nullptr)
	{
		printInAscending(mainRoot->left);
		std::cout << mainRoot->key << " ";
		printInAscending(mainRoot->right);
	}
}

void printInDecreasing(NodeOfTree *mainRoot)
{
	if (mainRoot != nullptr)
	{
		printInDecreasing(mainRoot->right);
		std::cout << mainRoot->key << " ";
		printInDecreasing(mainRoot->left);
	}
}

void deleteBinTree(NodeOfTree *root)
{
	if (root == nullptr)
	{
		delete root;
		return;
	}
	if (root->left != nullptr)
	{
		deleteBinTree(root->left);
	}
	if (root->right != nullptr)
	{
		deleteBinTree(root->right);
	}
	delete root;
}