#include <stdio.h>
#include <stdlib.h>

struct node
{
	int data;
	struct node *left;
	struct node *right;	
};
struct node *insert(struct node *root, int value){
    if(root == NULL){
        root = (struct node*) malloc(sizeof(struct node));
        root->left = root->right = NULL;
        root->data = value;
        return root;
    }else{
        if(value < root->data){
            root->left = insert(root->left, value);
        }else{
            if(value > root->data){
                root->right = insert(root->right, value);
            }
        }
        return root;
    }
};
void printGraphDfs(struct node *root)
{
	if(root!=NULL)
	{
		printGraphDfs(root->left);
		printf("%d ",root->data);
		printGraphDfs(root->right);
		
	}
}
//dEPTH LÝMÝTED SEARCH
void dls(struct node*root,int i,int limit)
{
 
		if(root!=NULL&&limit>0)
		{
				dls(root->left,i,limit-1);
				dls(root->right,i,limit-1);
				printf("%d  ",root->data);
		}	
 	
	
}
int main()
{
struct	node *root=NULL;
	//20 15 25 10 18 22 28
	root=insert(root,20);
	root=insert(root,15);
	root=insert(root,25);
	root=insert(root,10);
	root=insert(root,18);
	root=insert(root,22);
	root=insert(root,28); 
	dls(root, 0, 0);
		
	
	
}
