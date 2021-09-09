#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>

//dizimizi
int array[6][6];
bool visited[6]={false};
void readMatrix()
{
    int i = 0;
    FILE *fp = fopen("matrix1.txt", "r");
 
    while(fscanf(fp, "%d %d %d %d %d %d",
                 &array[i][0],
                 &array[i][1],
                 &array[i][2],
                 &array[i][3],
                 &array[i][4],
                 &array[i][5]
                 ) != EOF)
    {
        i = i + 1 ;
    }
}
int ii=-1;
void Dfs(int root,bool visited[])
{	
visited[root]=true;
	printf("%d",root);
  

	for(int i=0;i<6;i++)
	{
		if(array[root][i]==1 && visited[i]==false)
		{
			if(ii==1)
				{
					printf("limited deptf first search");
					return;
				}
			ii++;
			Dfs(i,visited);
		}
			
	}
	
}
int main()
{
	readMatrix();
	Dfs(0,visited);	
	printf("Derinlik %d",ii);
}
