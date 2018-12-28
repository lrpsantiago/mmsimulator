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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.tbExpectedBalance = new System.Windows.Forms.TextBox();
            this.tbProfitLoss = new System.Windows.Forms.TextBox();
            this.tbFinalBalance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTpMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRisk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAccuracy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBalance)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.mainChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.mainChart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisX.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisY.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            chartArea1.Name = "ChartArea1";
            this.mainChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.ForeColor = System.Drawing.Color.WhiteSmoke;
            legend1.Name = "Legend1";
            this.mainChart.Legends.Add(legend1);
            this.mainChart.Location = new System.Drawing.Point(323, 12);
            this.mainChart.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Color = System.Drawing.Color.Lime;
            series1.Legend = "Legend1";
            series1.Name = "Balance";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Color = System.Drawing.Color.DarkOrchid;
            series2.Legend = "Legend1";
            series2.Name = "Target";
            this.mainChart.Series.Add(series1);
            this.mainChart.Series.Add(series2);
            this.mainChart.Size = new System.Drawing.Size(465, 426);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 259);
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
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "TP Multiplier";
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
            100,
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
            this.btnRun.Size = new System.Drawing.Size(293, 38);
            this.btnRun.TabIndex = 8;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.tbExpectedBalance);
            this.groupBox2.Controls.Add(this.tbProfitLoss);
            this.groupBox2.Controls.Add(this.tbFinalBalance);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 161);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // tbExpectedBalance
            // 
            this.tbExpectedBalance.Location = new System.Drawing.Point(199, 71);
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
            // tbFinalBalance
            // 
            this.tbFinalBalance.Location = new System.Drawing.Point(199, 19);
            this.tbFinalBalance.Name = "tbFinalBalance";
            this.tbFinalBalance.ReadOnly = true;
            this.tbFinalBalance.Size = new System.Drawing.Size(100, 20);
            this.tbFinalBalance.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Profit / Loss";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Expected Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Final Balance";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(293, 58);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainChart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Money Management Simulator";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOptConservative;
        private System.Windows.Forms.Button btnOptAggressive;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbExpectedBalance;
        private System.Windows.Forms.TextBox tbProfitLoss;
        private System.Windows.Forms.TextBox tbFinalBalance;
    }
}

