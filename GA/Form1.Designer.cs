namespace GA
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnGARun = new System.Windows.Forms.Button();
            this.chkDispGA_EverySteps = new System.Windows.Forms.CheckBox();
            this.chkGATypeIsMin = new System.Windows.Forms.CheckBox();
            this.chkdomXi_IsNegative = new System.Windows.Forms.CheckBox();
            this.chkdomXi_isDouble = new System.Windows.Forms.CheckBox();
            this.txtdomXi = new System.Windows.Forms.TextBox();
            this.txtdimSize = new System.Windows.Forms.TextBox();
            this.txtdecP = new System.Windows.Forms.TextBox();
            this.txtpopSize = new System.Windows.Forms.TextBox();
            this.txtPm = new System.Windows.Forms.TextBox();
            this.txtPc = new System.Windows.Forms.TextBox();
            this.txtmaxGen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.combFitFunc = new System.Windows.Forms.ComboBox();
            this.lblFitnessFunc = new System.Windows.Forms.Label();
            this.lblMiliSecTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(138, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(557, 446);
            this.listBox1.TabIndex = 12;
            // 
            // btnGARun
            // 
            this.btnGARun.Location = new System.Drawing.Point(12, 24);
            this.btnGARun.Name = "btnGARun";
            this.btnGARun.Size = new System.Drawing.Size(120, 23);
            this.btnGARun.TabIndex = 0;
            this.btnGARun.Text = "Run GA";
            this.btnGARun.UseVisualStyleBackColor = true;
            this.btnGARun.Click += new System.EventHandler(this.button6_Click);
            // 
            // chkDispGA_EverySteps
            // 
            this.chkDispGA_EverySteps.AutoSize = true;
            this.chkDispGA_EverySteps.Checked = true;
            this.chkDispGA_EverySteps.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDispGA_EverySteps.Location = new System.Drawing.Point(12, 99);
            this.chkDispGA_EverySteps.Name = "chkDispGA_EverySteps";
            this.chkDispGA_EverySteps.Size = new System.Drawing.Size(120, 17);
            this.chkDispGA_EverySteps.TabIndex = 1;
            this.chkDispGA_EverySteps.Text = "dispGA_EverySteps";
            this.chkDispGA_EverySteps.UseVisualStyleBackColor = true;
            // 
            // chkGATypeIsMin
            // 
            this.chkGATypeIsMin.AutoSize = true;
            this.chkGATypeIsMin.Checked = true;
            this.chkGATypeIsMin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGATypeIsMin.Location = new System.Drawing.Point(12, 122);
            this.chkGATypeIsMin.Name = "chkGATypeIsMin";
            this.chkGATypeIsMin.Size = new System.Drawing.Size(90, 17);
            this.chkGATypeIsMin.TabIndex = 2;
            this.chkGATypeIsMin.Text = "GATypeIsMin";
            this.chkGATypeIsMin.UseVisualStyleBackColor = true;
            // 
            // chkdomXi_IsNegative
            // 
            this.chkdomXi_IsNegative.AutoSize = true;
            this.chkdomXi_IsNegative.Checked = true;
            this.chkdomXi_IsNegative.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkdomXi_IsNegative.Location = new System.Drawing.Point(12, 145);
            this.chkdomXi_IsNegative.Name = "chkdomXi_IsNegative";
            this.chkdomXi_IsNegative.Size = new System.Drawing.Size(111, 17);
            this.chkdomXi_IsNegative.TabIndex = 3;
            this.chkdomXi_IsNegative.Text = "domXi_isNegative";
            this.chkdomXi_IsNegative.UseVisualStyleBackColor = true;
            // 
            // chkdomXi_isDouble
            // 
            this.chkdomXi_isDouble.AutoSize = true;
            this.chkdomXi_isDouble.Checked = true;
            this.chkdomXi_isDouble.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkdomXi_isDouble.Location = new System.Drawing.Point(12, 168);
            this.chkdomXi_isDouble.Name = "chkdomXi_isDouble";
            this.chkdomXi_isDouble.Size = new System.Drawing.Size(102, 17);
            this.chkdomXi_isDouble.TabIndex = 4;
            this.chkdomXi_isDouble.Text = "domXi_isDouble";
            this.chkdomXi_isDouble.UseVisualStyleBackColor = true;
            // 
            // txtdomXi
            // 
            this.txtdomXi.Location = new System.Drawing.Point(85, 234);
            this.txtdomXi.Name = "txtdomXi";
            this.txtdomXi.Size = new System.Drawing.Size(47, 20);
            this.txtdomXi.TabIndex = 6;
            this.txtdomXi.Text = "10";
            this.txtdomXi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtdimSize
            // 
            this.txtdimSize.Location = new System.Drawing.Point(85, 208);
            this.txtdimSize.Name = "txtdimSize";
            this.txtdimSize.Size = new System.Drawing.Size(47, 20);
            this.txtdimSize.TabIndex = 5;
            this.txtdimSize.Text = "5";
            this.txtdimSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtdecP
            // 
            this.txtdecP.Location = new System.Drawing.Point(85, 260);
            this.txtdecP.Name = "txtdecP";
            this.txtdecP.Size = new System.Drawing.Size(47, 20);
            this.txtdecP.TabIndex = 7;
            this.txtdecP.Text = "5";
            this.txtdecP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtpopSize
            // 
            this.txtpopSize.Location = new System.Drawing.Point(85, 306);
            this.txtpopSize.Name = "txtpopSize";
            this.txtpopSize.Size = new System.Drawing.Size(47, 20);
            this.txtpopSize.TabIndex = 8;
            this.txtpopSize.Text = "50";
            this.txtpopSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPm
            // 
            this.txtPm.Location = new System.Drawing.Point(85, 384);
            this.txtPm.Name = "txtPm";
            this.txtPm.Size = new System.Drawing.Size(47, 20);
            this.txtPm.TabIndex = 11;
            this.txtPm.Text = "0.15";
            this.txtPm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPc
            // 
            this.txtPc.Location = new System.Drawing.Point(85, 358);
            this.txtPc.Name = "txtPc";
            this.txtPc.Size = new System.Drawing.Size(47, 20);
            this.txtPc.TabIndex = 10;
            this.txtPc.Text = "0.9";
            this.txtPc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtmaxGen
            // 
            this.txtmaxGen.Location = new System.Drawing.Point(85, 332);
            this.txtmaxGen.Name = "txtmaxGen";
            this.txtmaxGen.Size = new System.Drawing.Size(47, 20);
            this.txtmaxGen.TabIndex = 9;
            this.txtmaxGen.Text = "200";
            this.txtmaxGen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "domXi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "dimSize";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "popSize";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "decP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Pm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Pc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "maxGen";
            // 
            // combFitFunc
            // 
            this.combFitFunc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combFitFunc.FormattingEnabled = true;
            this.combFitFunc.Items.AddRange(new object[] {
            "y = Ackley ( Xi )",
            "y = Sum ( Xi ^ 2 )",
            "y = Sin ( Xi )",
            "y = 150 * X[0] + 100 * X[1] + 500 * X[2]"});
            this.combFitFunc.Location = new System.Drawing.Point(12, 62);
            this.combFitFunc.Name = "combFitFunc";
            this.combFitFunc.Size = new System.Drawing.Size(120, 21);
            this.combFitFunc.TabIndex = 20;
            this.combFitFunc.SelectedIndexChanged += new System.EventHandler(this.combFitFunc_SelectedIndexChanged);
            // 
            // lblFitnessFunc
            // 
            this.lblFitnessFunc.AutoSize = true;
            this.lblFitnessFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblFitnessFunc.ForeColor = System.Drawing.Color.Red;
            this.lblFitnessFunc.Location = new System.Drawing.Point(135, 5);
            this.lblFitnessFunc.Name = "lblFitnessFunc";
            this.lblFitnessFunc.Size = new System.Drawing.Size(194, 13);
            this.lblFitnessFunc.TabIndex = 21;
            this.lblFitnessFunc.Text = "Select Fitness Function Please...";
            // 
            // lblMiliSecTime
            // 
            this.lblMiliSecTime.AutoSize = true;
            this.lblMiliSecTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblMiliSecTime.ForeColor = System.Drawing.Color.Red;
            this.lblMiliSecTime.Location = new System.Drawing.Point(12, 430);
            this.lblMiliSecTime.Name = "lblMiliSecTime";
            this.lblMiliSecTime.Size = new System.Drawing.Size(19, 13);
            this.lblMiliSecTime.TabIndex = 22;
            this.lblMiliSecTime.Text = "---";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 481);
            this.Controls.Add(this.lblMiliSecTime);
            this.Controls.Add(this.lblFitnessFunc);
            this.Controls.Add(this.combFitFunc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPm);
            this.Controls.Add(this.txtPc);
            this.Controls.Add(this.txtmaxGen);
            this.Controls.Add(this.txtpopSize);
            this.Controls.Add(this.txtdecP);
            this.Controls.Add(this.txtdimSize);
            this.Controls.Add(this.txtdomXi);
            this.Controls.Add(this.chkdomXi_isDouble);
            this.Controls.Add(this.chkdomXi_IsNegative);
            this.Controls.Add(this.chkGATypeIsMin);
            this.Controls.Add(this.chkDispGA_EverySteps);
            this.Controls.Add(this.btnGARun);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnGARun;
        private System.Windows.Forms.CheckBox chkDispGA_EverySteps;
        private System.Windows.Forms.CheckBox chkGATypeIsMin;
        private System.Windows.Forms.CheckBox chkdomXi_IsNegative;
        private System.Windows.Forms.CheckBox chkdomXi_isDouble;
        private System.Windows.Forms.TextBox txtdomXi;
        private System.Windows.Forms.TextBox txtdimSize;
        private System.Windows.Forms.TextBox txtdecP;
        private System.Windows.Forms.TextBox txtpopSize;
        private System.Windows.Forms.TextBox txtPm;
        private System.Windows.Forms.TextBox txtPc;
        private System.Windows.Forms.TextBox txtmaxGen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combFitFunc;
        private System.Windows.Forms.Label lblFitnessFunc;
        private System.Windows.Forms.Label lblMiliSecTime;
    }
}

