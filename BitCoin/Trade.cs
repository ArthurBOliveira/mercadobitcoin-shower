using System;

namespace BitCoin
{
    public class Trade
    {
        public int tid { get; set; }
        public int date { get; set; }
        public string type { get; set; }
        public double price { get; set; }
        public double amount { get; set; }
        public TimeSpan datetime
        {
            get
            {
                return TimeSpan.FromMilliseconds(date);
            }
        }
    }

    public class Trades
    {
        public Trade[] trades { get; set; }
    }
}
