using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _8PuzzleAStar
{
    class QueePrinter
    {
        PriorityQuee quee=null;
        public QueePrinter(PriorityQuee quee)
        {
            this.quee = quee;
        }
        public void writeQuee()
        {
            StringBuilder builder = new StringBuilder();
            quee.nodes.ForEach(x=>builder.Append("F Cost \n"+x.fCost+"\n").Append(x.getMatrisAsString()).Append("\n---\n"));
            MessageBox.Show(builder.ToString());
            
        }
    }
}
