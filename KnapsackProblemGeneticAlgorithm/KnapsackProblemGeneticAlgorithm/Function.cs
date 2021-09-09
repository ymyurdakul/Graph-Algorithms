using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Function
    {
        public static int setFitness(Kromozom kro)
        {
            int ağırlık = 0,fayda=0;
            for (int i = 0; i < Program.GEN_SAYISI; i++)
            {
                if (kro.Genler[i].Value=='1')
	            {
		            ağırlık+=Program.agirlik[i];
                    fayda+=Program.fayda[i];
	            }
                 
            }
            int cost = fayda;
            if (ağırlık>Program.BOUND)
            {
                cost=cost-(cost*10);
            }
            return cost;
        }
        public static int setWeight(Kromozom kro)
        {

            int ağırlık = 0;
            for (int i = 0; i < Program.GEN_SAYISI; i++)
            {
                if (kro.Genler[i].Value == '1')
                {
                    ağırlık += Program.agirlik[i];
                   
                }

            }
            return ağırlık;
        }
    }
}
