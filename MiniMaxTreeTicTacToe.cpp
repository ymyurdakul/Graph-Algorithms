#include <stdio.h>
#include <stdlib.h>

// C++ program to find the next optimal move for 
// a player 
#include<bits/stdc++.h> 
using namespace std; 
struct Move
{
	int row,col;
};
bool isMovesLeft(char board[3][3]) 
{ 
    for (int i = 0; i<3; i++) 
        for (int j = 0; j<3; j++) 
            if (board[i][j]=='_') 
                return true; 
    return false; 
} 
char player='x',opponent='o';
int evaluate(char b[3][3]) 
{ 
    // Checking for Rows for X or O victory. 
    for (int row = 0; row<3; row++) 
    { 
        if (b[row][0]==b[row][1] && 
            b[row][1]==b[row][2]) 
        { 
            if (b[row][0]==player) 
                return +10; 
            else if (b[row][0]==opponent) 
                return -10; 
        } 
    } 
  
    // Checking for Columns for X or O victory. 
    for (int col = 0; col<3; col++) 
    { 
        if (b[0][col]==b[1][col] && 
            b[1][col]==b[2][col]) 
        { 
            if (b[0][col]==player) 
                return +10; 
  
            else if (b[0][col]==opponent) 
                return -10; 
        } 
    } 
  
    // Checking for Diagonals for X or O victory. 
    if (b[0][0]==b[1][1] && b[1][1]==b[2][2]) 
    { 
        if (b[0][0]==player) 
            return +10; 
        else if (b[0][0]==opponent) 
            return -10; 
    } 
  
    if (b[0][2]==b[1][1] && b[1][1]==b[2][0]) 
    { 
        if (b[0][2]==player) 
            return +10; 
        else if (b[0][2]==opponent) 
            return -10; 
    } 
  
    // Else if none of them have won then return 0 
    return 0; 
} 


int minimax(char board[3][3],bool isMax)
{
 int score=evaluate(board);
		if (score == 10) 
        return score; 
  
    // If Minimizer has won the game return his/her 
    // evaluated score 
    if (score == -10) 
        return score; 
  
    // If there are no more moves and no winner then 
    // it is a tie 
    if (isMovesLeft(board)==false) 
        return 0; 
        
        if(isMax)
        {
        	int best=-1000;
        	for(int i=0;i<3;i++)
        	{
        		for(int j=0;j<3;j++)
        		{
        			if(board[i][j]=='_')
        			{
        				board[i][j]=player;
        				best=max(best,minimax(board,!isMax));
        				board[i][j]='_';
						        				
					}
				}
			}
			return best;
		}
		else
		{
				int best=1000;
        	for(int i=0;i<3;i++)
        	{
        		for(int j=0;j<3;j++)
        		{
        			if(board[i][j]=='_')
        			{
        				board[i][j]=opponent;
        				best=min(best,minimax(board,!isMax));
						        board[i][j]='_';				
					}
				}
			}
			return best;
		}
        
	
	
}
Move bestMove;

Move findBestMove(char board[3][3])
{
	int bestVal=-1000;
	bestMove.col=-1;
	bestMove.row=-1;
	
	for(int i=0;i<3;i++)
	{
		for(int j=0;j<3;j++)
		{
			if(board[i][j]=='_')
			{
				board[i][j]=player;
				
				int moveVal=minimax(board,false);
				
				
				if(moveVal>bestVal)
				{
					bestMove.row=i;
					bestMove.col=j;
					bestVal=moveVal;
				}
			}
		}
	}
	 printf("The value of the best Move is : %d\n\n", 
            bestVal); 
  
    return bestMove; 
}

int main()
{
		 char board[3][3] = 
    { 
        { 'x', 'o', 'x' }, 
        { 'o', 'o', 'x' }, 
        { '_', '_', '_' } 
    }; 
  
    Move bestMove = findBestMove(board); 
  
    printf("The Optimal Move is :\n"); 
    printf("ROW: %d COL: %d\n\n", bestMove.row, 
                                  bestMove.col ); 
    return 0; 
}
