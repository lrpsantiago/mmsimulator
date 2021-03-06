﻿namespace MoneyManagementSimulator
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOptConservative = new System.Windows.Forms.Button();
            this.btnOptAggressive = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.nudTrades = new System.Windows.Forms.NumericUpDown();
            this.nudTpMultiplier = new System.Windows.Forms.NumericUpDown();
            this.nudRisk = new System.Windows.Forms.NumericUpDown();
            this.nudAccuracy = new System.Windows.Forms.NumericUpDown();
            this.nudBalance = new System.Windows.Forms.NumericUpDown();
            this.btnRun = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridResults = new System.Windows.Forms.DataGridView();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WinRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbExpectedBalance = new System.Windows.Forms.TextBox();
            this.tbProfitLoss = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.simulationProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTpMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRisk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAccuracy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBalance)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainChart
            // 
            this.mainChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.mainChart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.AxisX.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.AxisY.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            chartArea2.Name = "ChartArea1";
            this.mainChart.ChartAreas.Add(chartArea2);
            this.mainChart.Location = new System.Drawing.Point(323, 52);
            this.mainChart.Name = "mainChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Color = System.Drawing.Color.Lime;
            series3.Name = "Expected";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Color = System.Drawing.Color.DarkOrchid;
            series4.Name = "Selected";
            this.mainChart.Series.Add(series3);
            this.mainChart.Series.Add(series4);
            this.mainChart.Size = new System.Drawing.Size(673, 652);
            this.mainChart.TabIndex = 0;
            this.mainChart.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOptConservative);
            this.groupBox1.Controls.Add(this.btnOptAggressive);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblBalance);
            this.groupBox1.Controls.Add(this.nudTrades);
            this.groupBox1.Controls.Add(this.nudTpMultiplier);
            this.groupBox1.Controls.Add(this.nudRisk);
            this.groupBox1.Controls.Add(this.nudAccuracy);
            this.groupBox1.Controls.Add(this.nudBalance);
            this.groupBox1.Controls.Add(this.btnRun);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 258);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setup";
            // 
            // btnOptConservative
            // 
            this.btnOptConservative.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOptConservative.Location = new System.Drawing.Point(6, 149);
            this.btnOptConservative.Name = "btnOptConservative";
            this.btnOptConservative.Size = new System.Drawing.Size(293, 27);
            this.btnOptConservative.TabIndex = 6;
            this.btnOptConservative.Text = "Optimize Risk (Conservative)";
            this.btnOptConservative.UseVisualStyleBackColor = true;
            this.btnOptConservative.Click += new System.EventHandler(this.BtnOptConservative_Click);
            // 
            // btnOptAggressive
            // 
            this.btnOptAggressive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOptAggressive.Location = new System.Drawing.Point(6, 182);
            this.btnOptAggressive.Name = "btnOptAggressive";
            this.btnOptAggressive.Size = new System.Drawing.Size(293, 27);
            this.btnOptAggressive.TabIndex = 7;
            this.btnOptAggressive.Text = "Optimize Risk (Aggressive)";
            this.btnOptAggressive.UseVisualStyleBackColor = true;
            this.btnOptAggressive.Click += new System.EventHandler(this.BtnOptAggressive_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Trades";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Accuracy %";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Reward Multiplier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Risk %";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(6, 21);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(73, 13);
            this.lblBalance.TabIndex = 6;
            this.lblBalance.Text = "Initial Balance";
            // 
            // nudTrades
            // 
            this.nudTrades.Location = new System.Drawing.Point(179, 123);
            this.nudTrades.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTrades.Name = "nudTrades";
            this.nudTrades.Size = new System.Drawing.Size(120, 20);
            this.nudTrades.TabIndex = 5;
            this.nudTrades.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // nudTpMultiplier
            // 
            this.nudTpMultiplier.DecimalPlaces = 2;
            this.nudTpMultiplier.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudTpMultiplier.Location = new System.Drawing.Point(179, 71);
            this.nudTpMultiplier.Name = "nudTpMultiplier";
            this.nudTpMultiplier.Size = new System.Drawing.Size(120, 20);
            this.nudTpMultiplier.TabIndex = 3;
            this.nudTpMultiplier.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nudRisk
            // 
            this.nudRisk.DecimalPlaces = 2;
            this.nudRisk.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudRisk.Location = new System.Drawing.Point(179, 97);
            this.nudRisk.Name = "nudRisk";
            this.nudRisk.Size = new System.Drawing.Size(120, 20);
            this.nudRisk.TabIndex = 4;
            this.nudRisk.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // nudAccuracy
            // 
            this.nudAccuracy.DecimalPlaces = 2;
            this.nudAccuracy.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudAccuracy.Location = new System.Drawing.Point(179, 45);
            this.nudAccuracy.Name = "nudAccuracy";
            this.nudAccuracy.Size = new System.Drawing.Size(120, 20);
            this.nudAccuracy.TabIndex = 2;
            this.nudAccuracy.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nudBalance
            // 
            this.nudBalance.DecimalPlaces = 2;
            this.nudBalance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudBalance.Location = new System.Drawing.Point(179, 19);
            this.nudBalance.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudBalance.Name = "nudBalance";
            this.nudBalance.Size = new System.Drawing.Size(120, 20);
            this.nudBalance.TabIndex = 1;
            this.nudBalance.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Location = new System.Drawing.Point(6, 215);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(293, 37);
            this.btnRun.TabIndex = 8;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.gridResults);
            this.groupBox2.Controls.Add(this.tbExpectedBalance);
            this.groupBox2.Controls.Add(this.tbProfitLoss);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 388);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // gridResults
            // 
            this.gridResults.AllowUserToAddRows = false;
            this.gridResults.AllowUserToDeleteRows = false;
            this.gridResults.AllowUserToResizeColumns = false;
            this.gridResults.AllowUserToResizeRows = false;
            this.gridResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Balance,
            this.Wins,
            this.Loses,
            this.WinRate});
            this.gridResults.Location = new System.Drawing.Point(6, 71);
            this.gridResults.MultiSelect = false;
            this.gridResults.Name = "gridResults";
            this.gridResults.ReadOnly = true;
            this.gridResults.RowHeadersVisible = false;
            this.gridResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridResults.Size = new System.Drawing.Size(293, 311);
            this.gridResults.TabIndex = 7;
            this.gridResults.SelectionChanged += new System.EventHandler(this.gridResults_SelectionChanged);
            // 
            // Balance
            // 
            this.Balance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Balance.DataPropertyName = "Balance";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Balance.DefaultCellStyle = dataGridViewCellStyle3;
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            this.Balance.Width = 71;
            // 
            // Wins
            // 
            this.Wins.DataPropertyName = "Win";
            this.Wins.HeaderText = "Wins";
            this.Wins.Name = "Wins";
            this.Wins.ReadOnly = true;
            // 
            // Loses
            // 
            this.Loses.DataPropertyName = "Loss";
            this.Loses.HeaderText = "Loses";
            this.Loses.Name = "Loses";
            this.Loses.ReadOnly = true;
            // 
            // WinRate
            // 
            this.WinRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.WinRate.DataPropertyName = "WinRate";
            dataGridViewCellStyle4.Format = "P2";
            this.WinRate.DefaultCellStyle = dataGridViewCellStyle4;
            this.WinRate.HeaderText = "Win Rate";
            this.WinRate.Name = "WinRate";
            this.WinRate.ReadOnly = true;
            this.WinRate.Width = 77;
            // 
            // tbExpectedBalance
            // 
            this.tbExpectedBalance.Location = new System.Drawing.Point(199, 19);
            this.tbExpectedBalance.Name = "tbExpectedBalance";
            this.tbExpectedBalance.ReadOnly = true;
            this.tbExpectedBalance.Size = new System.Drawing.Size(100, 20);
            this.tbExpectedBalance.TabIndex = 6;
            // 
            // tbProfitLoss
            // 
            this.tbProfitLoss.Location = new System.Drawing.Point(199, 45);
            this.tbProfitLoss.Name = "tbProfitLoss";
            this.tbProfitLoss.ReadOnly = true;
            this.tbProfitLoss.Size = new System.Drawing.Size(100, 20);
            this.tbProfitLoss.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Expected Profit / Loss";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Expected Balance";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simulationProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 707);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // simulationProgressBar
            // 
            this.simulationProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.simulationProgressBar.Name = "simulationProgressBar";
            this.simulationProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStrip1.Size = new System.Drawing.Size(1008, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "runButton";
            this.toolStripButton1.ToolTipText = "Run";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainChart);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Money Management Simulator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTpMultiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRisk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAccuracy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBalance)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart mainChart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.NumericUpDown nudBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.NumericUpDown nudTrades;
        private System.Windows.Forms.NumericUpDown nudTpMultiplier;
        private System.Windows.Forms.NumericUpDown nudRisk;
        private System.Windows.Forms.NumericUpDown nudAccuracy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOptConservative;
        private System.Windows.Forms.Button btnOptAggressive;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbExpectedBalance;
        private System.Windows.Forms.TextBox tbProfitLoss;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripProgressBar simulationProgressBar;
        private System.Windows.Forms.DataGridView gridResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wins;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loses;
        private System.Windows.Forms.DataGridViewTextBoxColumn WinRate;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

