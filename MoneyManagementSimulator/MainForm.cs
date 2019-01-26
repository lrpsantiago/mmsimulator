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
        private Random _random = new Random();
        private List<StrategyResult> _results = new List<StrategyResult>();
        private HorizontalLineAnnotation _initialBalanceLine;

        public MainForm()
        {
            InitializeComponent();
            CreateLine();
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            var balance = Convert.ToDouble(nudBalance.Value);
            var accuracy = Convert.ToDouble(nudAccuracy.Value / 100);
            var risk = Convert.ToDouble(nudRisk.Value / 100);
            var tpMultiplier = Convert.ToDouble(nudTpMultiplier.Value);
            var trades = Convert.ToInt32(nudTrades.Value);
            var tries = 1000;
            var results = new List<StrategyResult>();

            mainChart.Series.Clear();
            _initialBalanceLine.Y = balance;

            for (int t = 0; t < tries; t++)
            {
                var serie = CreateSeries(Color.DimGray, 1);
                var result = new StrategyResult(balance);

                serie.Points.Add(balance);

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

                    serie.Points.Add(result.Balance);
                }

                results.Add(result);
                mainChart.Series.Add(serie);
            }

            tbFinalBalance.Text = results.Average(r => r.Balance).ToString("C2");
            //tbProfitLoss.Text = (result.Balance - balance).ToString("C2");

            gridResults.DataSource = results
                .Distinct()
                .OrderByDescending(r => r.Balance)
                .ToList();

            PlotTarget(balance, accuracy, tpMultiplier, risk, trades);

            mainChart.ChartAreas[0].RecalculateAxesScale();
        }

        private void BtnOptConservative_Click(object sender, EventArgs e)
        {
            var accuracy = Convert.ToDouble(nudAccuracy.Value / 100);
            var tpMultiplier = Convert.ToDouble(nudTpMultiplier.Value);
            var risk = CalculateRisk(accuracy, tpMultiplier) / 2;

            try
            {
                nudRisk.Value = Convert.ToDecimal(risk * 100);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnOptAggressive_Click(object sender, EventArgs e)
        {
            var accuracy = Convert.ToDouble(nudAccuracy.Value / 100);
            var tpMultiplier = Convert.ToDouble(nudTpMultiplier.Value);
            var risk = CalculateRisk(accuracy, tpMultiplier);

            try
            {
                nudRisk.Value = Convert.ToDecimal(risk * 100);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            var series = CreateSeries(Color.Lime, 2);
            series.Points.Add(balance);

            for (int i = 0; i < trades; i++)
            {
                var targetValue = CalculateTarget(balance, accuracy, tpMultiplier, risk, i + 1);

                series.Points.Add(targetValue);
            }

            mainChart.Series.Add(series);

            var finalBalance = CalculateTarget(balance, accuracy, tpMultiplier, risk, trades);
            tbExpectedBalance.Text = finalBalance.ToString("C2");
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
    }
}
