using System;

namespace MoneyManagementSimulator
{
    public class StrategyResult : IComparable, IComparable<StrategyResult>
    {
        public double Balance { get; set; }

        public int Win { get; set; }

        public int Loss { get; set; }

        public double WinRate
        {
            get
            {
                return (double)Win / (Win + Loss);
            }
        }

        public StrategyResult(double balance = 1000)
        {
            Balance = balance;
        }

        public int CompareTo(object obj)
        {
            var res = obj as StrategyResult;
            return CompareTo(obj);
        }

        public int CompareTo(StrategyResult other)
        {
            return Balance.CompareTo(other.Balance);
        }

        public override string ToString()
        {
            var perc = Math.Round(WinRate, 4) * 100;
            return $"Balance: {Balance} - Win: {Win} - Loss: {Loss} - Win Rate: {perc}%";
        }
    }
}
