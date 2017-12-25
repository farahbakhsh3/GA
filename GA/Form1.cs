using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace GA
{
    public partial class Form1 : Form
    {
        //////////////
        Stopwatch SW;

        public bool dispGA_EverySteps = false;
        public bool GATypeIsMin = true;
        public bool domXi_isNegative = true;
        public bool domXi_isDouble = true;
        public double domXi = 8;
        public int dimSize = 5;
        public int decP = 5;

        //////////////
        //////////////

        public int popSize = 50;
        public int maxGen = 200;
        public double Pc = .9;
        public double Pm = .15;

        public int cFitFunc = 0;

        public Random dblRnd = new Random();
        public Random intRnd = new Random();

        public int newPop = 0;
        public double[,] pop;
        // تعداد سطرها 4 برابر در نظر گرفته شده
        // یک برابر خود جمعیت
        // دو برابر فرزاندان
        // یک برابر جهش یافته ها

        public double fncFitness(double[] xx)
        {
            double y = 0;
            int d = xx.Length;

            switch (cFitFunc)
            {
                case (0):
                    ////////// مثال تابع Ackley
                    ////////// از نوع Min و ژن های مثبت و منفی از نوع اعشاری
                    //////////  تعریف تابع Ackley
                    double c = 2 * Math.PI;
                    double b = 0.2;
                    double a = 20;
                    double sum1 = 0;
                    double sum2 = 0;
                    double t1;
                    double t2;
                    for (int i = 0; i < d; i++)
                    {
                        sum1 = sum1 + xx[i] * xx[i];
                        sum2 = sum2 + Math.Cos(c * xx[i]);
                    }
                    t1 = -a * Math.Exp(-b * Math.Sqrt(sum1 / d));
                    t2 = -Math.Exp(sum2 / d);
                    y = t1 + t2 + a + Math.Exp(1);
                    y = Math.Round(y, decP);
                    break;
                /////////////////////////////////////

                case (1):
                    ////////// y = sum(Xi^2)
                    ////////// از نوع Min با متغیر های مثبت و منفی از نوع اعشاری
                    for (int i = 0; i < d; i++)
                        y += xx[i] * xx[i];
                    y = Math.Round(y, decP);
                    break;
                /////////////////////////////////////

                case (2):

                    ////////// y = sin(x)
                    ////////// از نوع Min or Max با متغیر های مثبت و منفی از نوع اعشاری

                    y = Math.Sin(xx[0]);
                    y = Math.Round(y, decP);
                    break;
                /////////////////////////////////////

                case (3):

                    ////////// مثال تولید کننده درب و میز و صندلی
                    ////////// از نوع Max با متغیر های فقط مثبت و نوع صحیح
                    ////////// بُعد مسئله  dimSize = 3
                    // X0 درب    ----    X1 میز   ----    X3 صندلی
                    //   سود به ترتیب شمارنده متغیر:
                    // X0 = 150 , X1 = 100 , X2 = 500
                    // محدودیت چوب بکار رفته در تولید هر محصول
                    // چوب بکار رفته در تولید هر محصول
                    // X0 = 70 , X1 = 90 , X2 = 20
                    // حداکثر موجودی چوب
                    // 1000
                    //////////
                    //////////

                    y = 150 * xx[0] + 100 * xx[1] + 500 * xx[2];
                    if (70 * xx[0] + 90 * xx[1] + 20 * xx[2] > 1000)
                        y = -1;
                    y = Math.Round(y, decP);
                    break;
            }
            return y;
        }

        void GAInit()
        {
            for (int i = 0; i < popSize; i++)
                for (int j = 0; j < dimSize; j++)
                    pop[i, j] = rndDoubleRound_domXi();
            newPop = popSize;
        }

        void GACrossOver()
        {
            int[] CrossPool = new int[popSize];
            int j = 0;
            // انتخاب کروموزومها
            for (int i = 0; i < popSize; i++)
                if (dblRnd.NextDouble() <= Pc)
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

            if (j % 2 != 0)
                j--;

            // CrosOver و اضافه کردن فرزندان به جمعیت
            if (dimSize > 1)
            {
                int CrossPoint;
                for (int i = 0; i < j; i += 2)
                {
                    CrossPoint = intRnd.Next(1, dimSize);
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
                pop[newPop, MutationPoint] = rndDoubleRound_domXi();
                newPop++;
            }
        }

        void GASelection()
        {
            // تشکیل ماتریس برازندگی
            double[,] popSelection = new double[newPop, dimSize + 1];
            double[] cromo = new double[dimSize];
            for (int i = 0; i < newPop; i++)
            {
                for (int t = 0; t < dimSize; t++)
                {
                    popSelection[i, t] = pop[i, t];
                    cromo[t] = pop[i, t];
                }
                popSelection[i, dimSize] = fncFitness(cromo);
            }

            // مرتب سازی ماتریس برازندگی
            double[] cromoTemp = new double[dimSize + 1];
            for (int i = 0; i < newPop; i++)
                for (int j = 0; j < newPop - 1; j++)
                    if (GATypeIsMin) // نوع مسله مشخص می شود  Min or Max و شیوه مرتب سازی تغییر می کند.
                    {
                        if (popSelection[j, dimSize] > popSelection[j + 1, dimSize])
                        {
                            for (int t = 0; t < dimSize + 1; t++)
                                cromoTemp[t] = popSelection[j, t];
                            for (int t = 0; t < dimSize + 1; t++)
                                popSelection[j, t] = popSelection[j + 1, t];
                            for (int t = 0; t < dimSize + 1; t++)
                                popSelection[j + 1, t] = cromoTemp[t];
                        }
                    }
                    else
                    {
                        if (popSelection[j, dimSize] < popSelection[j + 1, dimSize])
                        {
                            for (int t = 0; t < dimSize + 1; t++)
                                cromoTemp[t] = popSelection[j, t];
                            for (int t = 0; t < dimSize + 1; t++)
                                popSelection[j, t] = popSelection[j + 1, t];
                            for (int t = 0; t < dimSize + 1; t++)
                                popSelection[j + 1, t] = cromoTemp[t];
                        }
                    }

            // انتخاب بهترین جمعیت و انتقال به ماتریس pop
            for (int i = 0; i < popSize; i++)
                for (int t = 0; t < dimSize; t++)
                    pop[i, t] = popSelection[i, t];
            newPop = popSize;
        }

        void GARun()
        {
            SW = Stopwatch.StartNew();
            GAInit();
            if (dispGA_EverySteps)
                DispList(1);

            for (int i = 2; i <= maxGen; i++)
            {
                GACrossOver();
                GAMutation();
                GASelection();
                if (dispGA_EverySteps)
                    DispList(i);
            }
            if (!dispGA_EverySteps)
                DispList(maxGen);
            SW.Stop();
            double t = SW.ElapsedMilliseconds;
            lblMiliSecTime.Text = t.ToString() + " MiliSeconds";
        }

        public Form1()
        {
            InitializeComponent();
            combFitFunc.SelectedIndex = 0;
        }

        void DispList(int Generationsteps)
        {
            if (!dispGA_EverySteps)
                listBox1.Items.Clear();
            double[] xx = new double[dimSize];
            string s;
            for (int t = 0; t < newPop; t++)
            {
                s = "";
                for (int i = 0; i < dimSize; i++)
                {
                    xx[i] = pop[t, i];
                    s = s + "   " + xx[i];
                }
                listBox1.Items.Add(t + " [ " + s + " ]\t" + fncFitness(xx));
            }
            listBox1.Items.Add("------------------------------------------------------------");
            listBox1.Items.Add("--------- Generation " + Generationsteps + " : Finished ---------");
            listBox1.Items.Add("------------------------------------------------------------");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SetInitState();
            GARun();
        }

        double rndDoubleRound_domXi()
        {
            // مقدار تصادفی یک ژن
            // می تواند اعشاری یا صحیح باشد
            // می تواند در محدوده مثبت یا منفی باشد
            double res;
            if (domXi_isDouble)
            {
                if (domXi_isNegative)
                    res = Math.Round(dblRnd.NextDouble() * 2 * domXi - domXi, decP);
                else
                    res = Math.Round(dblRnd.NextDouble() * domXi, decP);
            }
            else
            {
                int int_domXi = Convert.ToInt32(Math.Round(domXi, 0)) + 1;
                if (domXi_isNegative)
                    res = intRnd.Next(int_domXi) * 2 - int_domXi;
                else
                    res = intRnd.Next(int_domXi);
            }
            return res;
        }
        void SetInitState()
        {
            dispGA_EverySteps = chkDispGA_EverySteps.Checked;
            GATypeIsMin = chkGATypeIsMin.Checked;
            domXi_isNegative = chkdomXi_IsNegative.Checked;
            domXi_isDouble = chkdomXi_isDouble.Checked;
            domXi = Convert.ToDouble(txtdomXi.Text);
            dimSize = Convert.ToInt32(txtdimSize.Text);
            decP = Convert.ToInt32(txtdecP.Text);
            popSize = Convert.ToInt32(txtpopSize.Text);
            maxGen = Convert.ToInt32(txtmaxGen.Text);
            Pc = Convert.ToDouble(txtPc.Text);
            Pm = Convert.ToDouble(txtPm.Text);
            ///
            ///
            pop = new double[4 * popSize, dimSize];
            ///
            cFitFunc = combFitFunc.SelectedIndex;
        }

        private void combFitFunc_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (combFitFunc.SelectedIndex)
            {
                case 0:
                    chkGATypeIsMin.Checked = true;
                    chkdomXi_IsNegative.Checked = true;
                    chkdomXi_isDouble.Checked = true;
                    txtdomXi.Text = "10";
                    txtdimSize.Text = "5";
                    break;
                case 1:
                    chkGATypeIsMin.Checked = true;
                    chkdomXi_IsNegative.Checked = true;
                    chkdomXi_isDouble.Checked = true;
                    txtdomXi.Text = "50";
                    txtdimSize.Text = "5";
                    break;
                case 2:
                    chkGATypeIsMin.Checked = true;
                    chkdomXi_IsNegative.Checked = true;
                    chkdomXi_isDouble.Checked = true;
                    txtdomXi.Text = (2 * Math.PI).ToString();
                    txtdimSize.Text = "1";
                    break;
                case 3:
                    chkGATypeIsMin.Checked = false;
                    chkdomXi_IsNegative.Checked = false;
                    chkdomXi_isDouble.Checked = false;
                    txtdomXi.Text = "100";
                    txtdimSize.Text = "3";
                    break;
            }
            lblFitnessFunc.Text = combFitFunc.Text;
        }
    }
}