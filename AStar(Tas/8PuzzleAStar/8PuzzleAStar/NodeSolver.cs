using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace _8PuzzleAStar
{
    class NodeSolver
    {

        public void calcRealistic(Node giris)
        {
            if (giris.parent==null)
                giris.realisticCost = 0;
            else
                giris.realisticCost = giris.parent.realisticCost + 1;
        
        }
        public bool compareMatris(Node x, Node y)
        {
            
            for (int satir = 0; satir < 3; satir++)
            {
                for (int sutun = 0; sutun < 3; sutun++)
                {

                    if ((x.matris[satir, sutun]) != y.matris[satir, sutun])
                        return false;

                }

            }
            return true;
        }
      public void calcHeuristic(Node giris,Node cikis)
      {

          //Yanlış olan digitlerin sayısı
          int heuristicValue = 0;
          for (int satir = 0; satir < 3; satir++)
          {
              for (int sutun = 0; sutun < 3; sutun++)
              {
                  if (giris.matris[satir, sutun] == 0)
                      continue;

                  if ((giris.matris[satir, sutun]) != cikis.matris[satir, sutun])
                      heuristicValue++;

              }

          }
          giris.heuristicCost = heuristicValue;

       


      }
      public void calcFVal(Node node)
      {
          node.fCost = node.heuristicCost + node.realisticCost;
            
      }
      public void createSuccessor(Node giris)
      {

          //Boşluğun nerde oldugunu anlamaya yarar
          int satirPos = 0;
          int sutunPos = 0;
          bool isFound = false;
          for (int satir = 0; satir < 3; satir++)
          {
              for (int sutun = 0; sutun < 3; sutun++)
              {
                  if (giris.matris[satir, sutun] == 0)
                  {
                      satirPos = satir;
                      sutunPos = sutun;
                      isFound = true;
                      break;
                  }
                  if (isFound) break;
              }
          }
          Node sag = swap(giris,satirPos, sutunPos, satirPos, sutunPos + 1);
          Node sol = swap(giris,satirPos, sutunPos, satirPos, sutunPos - 1);


          Node alt = swap(giris,satirPos, sutunPos, satirPos + 1, sutunPos);
          Node üst = swap(giris,satirPos, sutunPos, satirPos - 1, sutunPos);
          if (sag != null)
          {
              sag.parent = giris;
              giris.successor.Add(sag);


          }
          if (sol != null)
          {
              sol.parent = giris;
              giris.successor.Add(sol);

          }
          if (alt != null)
          {
              alt.parent = giris;
              giris.successor.Add(alt);
          }
          if (üst != null)
          {
              üst.parent = giris;
              giris.successor.Add(üst);
          }

      }


      public Node swap(Node giris,int mevcutSatir, int mevcutSutun, int toSatir, int toSutun)
      {
          if (toSatir < 0 | toSutun < 0 | toSutun > 2 | toSatir > 2)
              return null;
          int[,] matrisCopy = (int[,])giris.matris.Clone();

          int temp = matrisCopy[mevcutSatir, mevcutSutun];
          matrisCopy[mevcutSatir, mevcutSutun] = matrisCopy[toSatir, toSutun];
          matrisCopy[toSatir, toSutun] = temp;

          //writeMatris(matrisCopy);
          Node t = new Node();
          t.setMatris(matrisCopy);

          return t;
      }


    }
}
