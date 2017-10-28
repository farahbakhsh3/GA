using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GA
{
    public partial class Form1 : Form
    {
        static int decP = 3;
        static int domXi = 10;
        static int dimSize = 5;
        static int popSize = 50;
        static int maxGen = 200;
        static double Pc = .9;
        static double Pm = .15;

        Random dblRnd = new Random();
        Random intRnd = new Random();

        public int newPop = 0;
        double[,] pop = new double[4 * popSize, dimSize];

        double Ackley(double[] xx)
        {
            double y;
            double c = 2 * Math.PI;
            double b = 0.2;
            double a = 20;
            double sum1 = 0;
            double sum2 = 0;
            double term1;
            double term2;
            int d = xx.Length;
            for (int i = 0; i < d; i++)
            {
                sum1 = sum1 + xx[i] * xx[i];
                sum2 = sum2 + Math.Cos(c * xx[i]);
            }
            term1 = -a * Math.Exp(-b * Math.Sqrt(sum1 / d));
            term2 = -Math.Exp(sum2 / d);
            y = term1 + term2 + a + Math.Exp(1);
            return Math.Round(y, decP);
        }

        void GAInit()
        {
            for (int i = 0; i < popSize; i++)
                for (int j = 0; j < dimSize; j++)
                    pop[i, j] = Math.Round(dblRnd.NextDouble() * domXi, decP);
            newPop = popSize;
        }

        void GACrossOver()
        {
            int[] CrossPool = new int[popSize];
            int j = 0;
            // انتخاب کروموزومها
            for (int i = 0; i < popSize; i++)
                if (dblRnd.NextDouble() < Pc)
                {
                    CrossPool[j] = i;
                    j++;
                }
            // انتخاب جفتها به شیوه بُر زدن آرایه
            int t;
            int temp;
            for (int i = 0; i < j; i++)
            {
                t = intRnd.Next(j);
                temp = CrossPool[i];
                CrossPool[i] = CrossPool[t];
                CrossPool[t] = temp;
            }
            // CrosOver و اضافه کردن فرزندان به جمعیت
            if (j % 2 != 0)
                j--;

            int CrossPoint;
            for (int i = 0; i < j; i += 2)
            {
                CrossPoint = intRnd.Next(1, dimSize - 1);
                for (t = 0; t < CrossPoint; t++)
                {
                    pop[newPop, t] = pop[CrossPool[i], t];
                    pop[newPop + 1, t] = pop[CrossPool[i + 1], t];
                }
                for (t = CrossPoint; t < dimSize; t++)
                {
                    pop[newPop, t] = pop[CrossPool[i + 1], t];
                    pop[newPop + 1, t] = pop[CrossPool[i], t];
                }
                newPop += 2;
            }
        }

        void GAMutation()
        {
            int[] MutationPool = new int[newPop];
            int j = 0;
            // انتخاب کروموزومها برای جهش
            for (int i = 0; i < newPop; i++)
                if (dblRnd.NextDouble() <= Pm)
                {
                    MutationPool[j] = i;
                    j++;
                }
            // انتخاب ژن و جهش و اضافه شدن به جمعیت
            int MutationPoint;
            int t;
            for (int i = 0; i < j; i++)
            {
                MutationPoint = intRnd.Next(dimSize);
                for (t = 0; t < dimSize; t++)
                {
                    pop[newPop, t] = pop[MutationPool[i], t];
                }
                pop[newPop, MutationPoint] = Math.Round(dblRnd.NextDouble() * domXi, decP);
                newPop++;
            }
        }

        void GASelection()
        {
            double[,] popSelection = new double[newPop, dimSize + 1];
            double[] cromo = new double[dimSize];
            for (int i = 0; i < newPop; i++)
            {
                for (int t = 0; t < dimSize;t++)
                {
                    popSelection[i, t] = pop[i, t];
                    cromo[t] = pop[i, t];
                }
                popSelection[i, dimSize] = Ackley(cromo);
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            double[] xx = new double[dimSize];
            string s;
            for (int t = 0; t < newPop; t++)
            {
                s = "";
                for (int i = 0; i < dimSize; i++)
                {
                    xx[i] = pop[t, i];
                    s = s + "  " + xx[i];
                }
                listBox1.Items.Add(t + " [" + s + " ]\t" + Ackley(xx));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GACrossOver();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GAInit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GAMutation();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GASelection();
        }
    }
}