using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnapsackProblem.cs
{
    class Population
    {
        public static Random rnd=new Random();
        public int[,] liste;
      
        public Population()
        { 
            liste=new int[10,7];

        }
        public void random() { 
            for (int i = 0; i < 10; i++)
			{
                int []matris=new int[7];
			    for (int j = 0; j < 7; j++)
			    {
                    if (rnd.Next()%2==0)
                    {
                        matris[j] = 1;
                    }
                    else
                    {
                        matris[j] = 0;
                    }
			     
			    }
                if (Function.calc(matris,KnapsackProblem.cs.Program.itemProfitAndWeigth)>9)
                {
                    i--;
                    continue;
                }
                matrisKopyala(matris,i);
                
			}
        }
        public void matrisKopyala(int []matris,int pos)
        {
            for (int i = 0; i < 7; i++)
            {
                liste[pos,i]=matris[i];
            }  
        }

    }
}
