using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Kromozom
    {
        public static Random rnd = new Random();
        public const int genSayisi = 4;
        public int fitness;
        public Gen[] genes;
        public Kromozom()
        {
            genes=new Gen[4];
            for (int i = 0; i < 4; i++)
            {
                genes[i]=new Gen( rnd.Next(4));
            }
            setFitneess();
        }
        public void writeGen()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write(genes[i].gen+" ");
            }
            Console.Write("--->"+fitness);
        }
        public int setFitneess()
        {
            EightQueenMatrix matrix = new EightQueenMatrix();
            matrix.matrisSıfırla();
            matrix.setMatris(new int[]{genes[0].gen,genes[1].gen,genes[2].gen,genes[3].gen});
            fitness = matrix.getFullCost(matrix.matris);
           return matrix.getFullCost(matrix.matris);
        }



    }
}
