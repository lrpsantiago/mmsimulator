using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MoneyManagementSimulator
{
    public partial class MainForm : Form
    {
        private readonly Random _random = new Random();
        private HorizontalLineAnnotation _initialBalanceLine;

        public MainForm()
        {
            InitializeComponent();
            CreateLine();
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            RunSimulations();
        }

        private void BtnOptConservative_Click(object sender, EventArgs e)
        {
            var accuracy = Convert.ToDouble(nudAccuracy.Value / 100);
            var tpMultiplier = Convert.ToDouble(nudTpMultiplier.Value);
            var risk = CalculateRisk(accuracy, tpMultiplier) / 2;

            try
            {
                if (risk < 0)
                {
                    throw new Exception("Not possible to optimize the risk with the given parameters.");
                }

                nudRisk.Value = Convert.ToDecimal(risk * 100);
            }
            catch (Exception ex)
            {
                DialogUtil.ShowError(ex.Message);
            }
        }

        private void BtnOptAggressive_Click(object sender, EventArgs e)
        {
            var accuracy = Convert.ToDouble(nudAccuracy.Value / 100);
            var tpMultiplier = Convert.ToDouble(nudTpMultiplier.Value);
            var risk = CalculateRisk(accuracy, tpMultiplier);

            try
            {
                if (risk < 0)
                {
                    throw new Exception("Not possible to optimize the risk with the given parameters.");
                }

                nudRisk.Value = Convert.ToDecimal(risk * 100);
            }
            catch (Exception ex)
            {
                DialogUtil.ShowError(ex.Message);
            }
        }

        private double CalculateRisk(double accuracy, double tpMultiplier)
        {
            return (tpMultiplier * accuracy - (1 - accuracy)) / tpMultiplier;
        }

        private double CalculateTarget(double initialBalance, double accuracy, double tpMultiplier, double risk,
            int trades)
        {
            var win = Math.Floor(trades * accuracy);
            var loss = Math.Ceiling(trades * (1 - accuracy));
            var winModifier = (initialBalance + (initialBalance * risk * tpMultiplier)) / initialBalance;
            var lossModifier = (initialBalance - (initialBalance * risk)) / initialBalance;

            return initialBalance * Math.Pow(winModifier, win) * Math.Pow(lossModifier, loss);
        }

        private void CreateLine()
        {
            _initialBalanceLine = new HorizontalLineAnnotation
            {
                AxisX = mainChart.ChartAreas[0].AxisX,
                AxisY = mainChart.ChartAreas[0].AxisY,
                IsInfinitive = true,
                ClipToChartArea = mainChart.ChartAreas[0].Name,
                LineColor = Color.WhiteSmoke,
                LineDashStyle = ChartDashStyle.Dash
            };

            mainChart.Annotations.Add(_initialBalanceLine);
        }

        private void PlotTarget(double balance, double accuracy, double tpMultiplier, double risk, int trades)
        {
            var series = mainChart.Series[0]; //CreateSeries(Color.Lime, 2);
            series.Points.Add(balance);

            for (int i = 0; i < trades; i++)
            {
                var targetValue = CalculateTarget(balance, accuracy, tpMultiplier, risk, i + 1);

                series.Points.Add(targetValue);
            }

            //mainChart.Series.Add(series);

            var finalBalance = CalculateTarget(balance, accuracy, tpMultiplier, risk, trades);
            tbExpectedBalance.Text = finalBalance.ToString("C2");
            tbProfitLoss.Text = (finalBalance - balance).ToString("C2");
        }

        private Series CreateSeries(Color lineColor, int lineWidth)
        {
            return new Series
            {
                ChartType = SeriesChartType.FastLine,
                Color = lineColor,
                BorderWidth = lineWidth
            };
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            RunSimulations();
        }

        private void RunSimulations()
        {
            var balance = Convert.ToDouble(nudBalance.Value);
            var accuracy = Convert.ToDouble(nudAccuracy.Value / 100);
            var risk = Convert.ToDouble(nudRisk.Value / 100);
            var tpMultiplier = Convert.ToDouble(nudTpMultiplier.Value);
            var trades = Convert.ToInt32(nudTrades.Value);
            var tries = 1000;
            var results = new List<StrategyResult>();

            simulationProgressBar.Minimum = 0;
            simulationProgressBar.Maximum = tries;

            for (int t = 0; t < tries; t++)
            {
                var result = new StrategyResult(balance);

                for (int i = 0; i < trades; i++)
                {
                    if (result.Balance < 0)
                    {
                        break;
                    }

                    var rand = _random.NextDouble();

                    if (rand < accuracy)
                    {
                        result.Balance += (result.Balance * risk) * tpMultiplier;
                        result.Win++;
                    }
                    else
                    {
                        result.Balance -= (result.Balance * risk);
                        result.Loss++;
                    }

                    result.BalanceHistory.Add(result.Balance);
                }

                results.Add(result);

                simulationProgressBar.Value = t;
            }

            ClearPoints();
            _initialBalanceLine.Y = balance;

            gridResults.DataSource = results
                .Distinct()
                .OrderByDescending(r => r.Balance)
                .ToList();

            PlotTarget(balance, accuracy, tpMultiplier, risk, trades);

            mainChart.ChartAreas[0].RecalculateAxesScale();
        }

        private void ClearPoints()
        {
            foreach (var serie in mainChart.Series)
            {
                serie.Points.Clear();
            }
        }

        private void gridResults_SelectionChanged(object sender, EventArgs e)
        {
            if (gridResults.SelectedRows.Count <= 0)
            {
                return;
            }

            var selectedRow = gridResults.SelectedRows[0];

            if (selectedRow == null)
            {
                return;
            }

            var item = selectedRow.DataBoundItem as StrategyResult;
            var series = mainChart.Series[1];
            series.Points.Clear();

            foreach (var point in item.BalanceHistory)
            {
                series.Points.Add(point);
            }

            //mainChart.Series.Add(series);
            mainChart.ChartAreas[0].RecalculateAxesScale();
        }
    }
}
