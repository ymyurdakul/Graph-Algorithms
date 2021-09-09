#include <stdio.h>
#include <cstring>
#include <string>
#define N 6
#define EBAS 0x7FFFFFF
void dijkstra();

int graf[N][N]={{-1,7,4,-1,2,-1},
				{7,-1,3,2,-1,6},
				{4,3,-1,8,1,-1},
				{-1,2,8,-1,10,3}
				,{2,-1,1,10,-1,-1},
				{-1,6,-1,3,-1,-1}
				};
int liste[N];
void dijkstra()
{
    bool visited[N]={0};
	int i,j,ptr,ek;
	liste[0]=0;
	for(i=1;i<N;++i)
		liste[i]=EBAS;
	ptr=0;
	
	for(i=0;i<N;i++)
	{
		for(j=0;j<N;++j)
		 if(!visited[j])
		 if(graf[ptr][j]!=-1)
		 ///eger listedeki veride grafýn degeri + listenin mevcut konumu ek
		 //lendiginde kücükse güncelle
		 if(graf[ptr][j]+liste[ptr]<liste[j])
		{
			liste[j]=graf[ptr][j]+liste[ptr];
		 
		}
		ek=EBAS;
		
		for(j=0;j<N;j++)
		if(!visited[j])
		if(liste[j]<ek)
		{ 
			ek=liste[j];
			ptr=j;
		}
		visited[ptr]=1;
	}
	
	
}

int main()
{
	int i;
	dijkstra();
	printf("Komsuluk Matrisi\n");
	for(i=0;i<N;i++)
	{
		for(int j=0;j<N;j++)
		printf("%5d",graf[i][j]);
		printf("\n\n");
	}
	
	printf("Maliyetler\n");
	for(i=0;i<N;i++)
	printf("EKM[%d]=%d\n",i,liste[i]);
	
	/*
	printf("Rotalar\n");
	for(i=0;i<N;i++)
		printf("rota[%d]=%s\N",i,rota[i]);
	*/
}

