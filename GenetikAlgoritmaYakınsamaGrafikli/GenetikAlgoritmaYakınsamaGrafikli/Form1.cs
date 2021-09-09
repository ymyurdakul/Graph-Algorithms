using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            FitnessCalc.setSolution("0000000000000000000000000000000000000000000000000000000000000000");
            Population myPop = new Population(1000, true);
            List<int> yakınsama = new List<int>();
            for (int i = 0; i < Convert.ToInt16(textBox1.Text); i++)
            {
                
           
            
           
                yakınsama.Add(myPop.getFittest().getFitness());
                listBox1.Items.Add(myPop.getFittest().ToString() + " Fitness::" + myPop.getFittest().getFitness());
                if (i % 2 == 0)
                    myPop = Algorithm.evolvePopualation(myPop, true);
                else
                    myPop = Algorithm.evolvePopualation(myPop, false);
            }
            listBox1.Items.Add(myPop.getFittest().ToString() + "   Fitness::" + myPop.getFittest().getFitness());
            chart1.Series["x"].Points.Clear();
            for (int i = 0; i < yakınsama.Count; i++)
            {
                chart1.Series["x"].Points.Add(yakınsama[i]);
            }
           
             
        }
    }
}
