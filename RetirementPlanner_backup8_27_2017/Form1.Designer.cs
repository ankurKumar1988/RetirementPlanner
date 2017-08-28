namespace RetirementPlanner
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.save_plan = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label21 = new System.Windows.Forms.Label();
            this.Results_text = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Current_savings = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.year_2_retire = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Expected_ror = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Pct_IncomeSaved_incr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Pct_incomeMatch = new System.Windows.Forms.TextBox();
            this.compute = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Pct_IncomeSaved = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Pct_annIncrease = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.annIncome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.delete_entry = new System.Windows.Forms.Button();
            this.load_entry = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1248, 743);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.save_plan);
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.Results_text);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.Current_savings);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.year_2_retire);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.Expected_ror);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.Pct_IncomeSaved_incr);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.Pct_incomeMatch);
            this.tabPage1.Controls.Add(this.compute);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.Pct_IncomeSaved);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.Pct_annIncrease);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.annIncome);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.splitter1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage1.Size = new System.Drawing.Size(1240, 710);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create New Plan";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // save_plan
            // 
            this.save_plan.BackColor = System.Drawing.Color.LightSkyBlue;
            this.save_plan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_plan.ForeColor = System.Drawing.Color.Navy;
            this.save_plan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save_plan.Location = new System.Drawing.Point(325, 647);
            this.save_plan.Name = "save_plan";
            this.save_plan.Size = new System.Drawing.Size(160, 46);
            this.save_plan.TabIndex = 34;
            this.save_plan.Text = "Save";
            this.save_plan.UseVisualStyleBackColor = false;
            this.save_plan.Click += new System.EventHandler(this.save_data_Click);
            // 
            // chart1
            // 
            chartArea3.AxisX.Title = "Years";
            chartArea3.AxisY.Title = "Your Savings (in $)";
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(531, 65);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(434, 302);
            this.chart1.TabIndex = 33;
            this.chart1.Text = "chart1";
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.SeaShell;
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.DarkRed;
            this.label21.Location = new System.Drawing.Point(520, 408);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(279, 32);
            this.label21.TabIndex = 31;
            this.label21.Text = "Results (Text):";
            // 
            // Results_text
            // 
            this.Results_text.Location = new System.Drawing.Point(520, 452);
            this.Results_text.Multiline = true;
            this.Results_text.Name = "Results_text";
            this.Results_text.ReadOnly = true;
            this.Results_text.Size = new System.Drawing.Size(457, 253);
            this.Results_text.TabIndex = 30;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.SeaShell;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DarkRed;
            this.label20.Location = new System.Drawing.Point(515, 15);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(279, 32);
            this.label20.TabIndex = 29;
            this.label20.Text = "Results (Graphical View):";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.Control;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(364, 596);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(20, 22);
            this.label18.TabIndex = 28;
            this.label18.Text = "$";
            // 
            // Current_savings
            // 
            this.Current_savings.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Current_savings.Location = new System.Drawing.Point(239, 593);
            this.Current_savings.Name = "Current_savings";
            this.Current_savings.Size = new System.Drawing.Size(122, 26);
            this.Current_savings.TabIndex = 27;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.Control;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(39, 593);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(136, 22);
            this.label19.TabIndex = 26;
            this.label19.Text = "Current savings";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.Control;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(288, 553);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 22);
            this.label16.TabIndex = 25;
            this.label16.Text = "%";
            // 
            // year_2_retire
            // 
            this.year_2_retire.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.year_2_retire.Location = new System.Drawing.Point(239, 552);
            this.year_2_retire.Name = "year_2_retire";
            this.year_2_retire.Size = new System.Drawing.Size(43, 26);
            this.year_2_retire.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.Control;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(38, 552);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(162, 22);
            this.label17.TabIndex = 23;
            this.label17.Text = "Years to retirement";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(288, 512);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 22);
            this.label14.TabIndex = 22;
            this.label14.Text = "%";
            // 
            // Expected_ror
            // 
            this.Expected_ror.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Expected_ror.Location = new System.Drawing.Point(239, 511);
            this.Expected_ror.Name = "Expected_ror";
            this.Expected_ror.Size = new System.Drawing.Size(43, 26);
            this.Expected_ror.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.Control;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(38, 511);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(193, 22);
            this.label15.TabIndex = 20;
            this.label15.Text = "Expected rate of return";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.SeaShell;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkRed;
            this.label13.Location = new System.Drawing.Point(9, 452);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(170, 32);
            this.label13.TabIndex = 19;
            this.label13.Text = "Other Details:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(286, 355);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 22);
            this.label12.TabIndex = 18;
            this.label12.Text = "%";
            // 
            // Pct_IncomeSaved_incr
            // 
            this.Pct_IncomeSaved_incr.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Pct_IncomeSaved_incr.Location = new System.Drawing.Point(237, 354);
            this.Pct_IncomeSaved_incr.Name = "Pct_IncomeSaved_incr";
            this.Pct_IncomeSaved_incr.Size = new System.Drawing.Size(43, 26);
            this.Pct_IncomeSaved_incr.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(285, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(36, 345);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 44);
            this.label11.TabIndex = 15;
            this.label11.Text = "Income saved \r\nannual increment";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(296, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 22);
            this.label10.TabIndex = 14;
            this.label10.Text = "%";
            // 
            // Pct_incomeMatch
            // 
            this.Pct_incomeMatch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Pct_incomeMatch.Location = new System.Drawing.Point(237, 284);
            this.Pct_incomeMatch.Name = "Pct_incomeMatch";
            this.Pct_incomeMatch.Size = new System.Drawing.Size(51, 26);
            this.Pct_incomeMatch.TabIndex = 13;
            // 
            // compute
            // 
            this.compute.BackColor = System.Drawing.Color.LightSkyBlue;
            this.compute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compute.ForeColor = System.Drawing.Color.Navy;
            this.compute.Image = global::RetirementPlanner.Properties.Resources.if_ok_sign_173063__1_;
            this.compute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.compute.Location = new System.Drawing.Point(128, 647);
            this.compute.Name = "compute";
            this.compute.Size = new System.Drawing.Size(160, 46);
            this.compute.TabIndex = 12;
            this.compute.Text = "    Compute";
            this.compute.UseVisualStyleBackColor = false;
            this.compute.Click += new System.EventHandler(this.compute_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 44);
            this.label9.TabIndex = 11;
            this.label9.Text = "Income co-matched\r\nby employer";
            // 
            // Pct_IncomeSaved
            // 
            this.Pct_IncomeSaved.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Pct_IncomeSaved.Location = new System.Drawing.Point(236, 239);
            this.Pct_IncomeSaved.Name = "Pct_IncomeSaved";
            this.Pct_IncomeSaved.Size = new System.Drawing.Size(43, 26);
            this.Pct_IncomeSaved.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "Income saved";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.SeaShell;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(9, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "Savings Details:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(288, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "%";
            // 
            // Pct_annIncrease
            // 
            this.Pct_annIncrease.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Pct_annIncrease.Location = new System.Drawing.Point(233, 101);
            this.Pct_annIncrease.Name = "Pct_annIncrease";
            this.Pct_annIncrease.Size = new System.Drawing.Size(51, 26);
            this.Pct_annIncrease.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "% annual increase ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(358, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "$";
            // 
            // annIncome
            // 
            this.annIncome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.annIncome.Location = new System.Drawing.Point(233, 62);
            this.annIncome.Name = "annIncome";
            this.annIncome.Size = new System.Drawing.Size(122, 26);
            this.annIncome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current annual income";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Income Details:";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(5, 5);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(504, 700);
            this.splitter1.TabIndex = 32;
            this.splitter1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.delete_entry);
            this.tabPage2.Controls.Add(this.load_entry);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1240, 710);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Plan History";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // delete_entry
            // 
            this.delete_entry.Location = new System.Drawing.Point(220, 666);
            this.delete_entry.Name = "delete_entry";
            this.delete_entry.Size = new System.Drawing.Size(178, 36);
            this.delete_entry.TabIndex = 1;
            this.delete_entry.Text = "Delete Selected Entry";
            this.delete_entry.UseVisualStyleBackColor = true;
            this.delete_entry.Click += new System.EventHandler(this.delete_entry_Click);
            // 
            // load_entry
            // 
            this.load_entry.Location = new System.Drawing.Point(6, 666);
            this.load_entry.Name = "load_entry";
            this.load_entry.Size = new System.Drawing.Size(178, 36);
            this.load_entry.TabIndex = 1;
            this.load_entry.Text = "Load Selected Entry";
            this.load_entry.UseVisualStyleBackColor = true;
            this.load_entry.Click += new System.EventHandler(this.load_entry_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1240, 638);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 743);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Retirement Planner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox annIncome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Pct_annIncrease;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Pct_IncomeSaved;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Pct_incomeMatch;
        private System.Windows.Forms.Button compute;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Pct_IncomeSaved_incr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Expected_ror;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox year_2_retire;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox Current_savings;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox Results_text;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button save_plan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button load_entry;
        private System.Windows.Forms.Button delete_entry;
    }
}

