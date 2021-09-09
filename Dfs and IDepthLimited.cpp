#include <stdio.h>
#include <stdlib.h>

struct node
{
	int data;
	struct node *left;
	struct node *right;	
};
struct node *insert(struct node *root,int val)
{
	if(root==NULL)
		{
		root = (struct node*) malloc(sizeof(struct node));
			root->left=root->right=NULL;
			root->data=val;
			return root;
		}
		else
		 
			if(val<root->data)
			{
				root->left=insert(root->left,val);
				
			}
			
		 else 
		 
		 if(val>root->data)
		 {
		 	root->right=insert(root->right,val);
		 	
		 }
		 return root;
}
void printGraphDfs(struct node *root)
{
	if(root!=NULL)
	{
		printGraphDfs(root->left);
		printGraphDfs(root->right);
		printf("%d",root->data);
	}
}
int main()
{
	node *root;
	//20 15 25 10 18 22 28
	insert(root,20);insert(root,15);insert(root,25);insert(root,10);
		insert(root,18);insert(root,22);insert(root,28); 
		printGraphDfs(root);
		
	
	
}
