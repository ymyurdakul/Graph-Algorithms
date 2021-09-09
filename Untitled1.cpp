#include <stdio.h>
#include <stdlib.h>
#define MAX 10

int findInDegree(int matris[][4],int pos)
{
	int count=0;
	for(int i=0;i<4;i++)
		if(matris[i][pos]==1)
			count++;
			return count;
			
}
int findOutDegree(int matris[][4],int x)
{
	int count=0;
	for(int i=0;i<4;i++)
		if(matris[x][i]==1||matris[i][x]==1)
			count++;
			return count;
			
	
	
}
int main()
{
	int matris[4][4]={
	/*  0 1 2 3*/
/* 0*/	0,1,0,1
/* 1*/	,0,0,0,1
/* 2*/	,1,0,0,0
/*3*/	,0,0,1,0
	};
	//printf("%d",matris[2][0]);
	int res= findInDegree(matris,3);
	int res1= findOutDegree(matris,3);
	printf("%d",res1);
	
}
