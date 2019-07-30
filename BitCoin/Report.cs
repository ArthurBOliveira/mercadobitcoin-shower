using System;
using System.Collections.Generic;

namespace BitCoin
{
    public class Report
    {
        public DateTime Date { get; set; }
        public List<Trade> Trades { get; set; }
        public int UpCount { get; set; }
        public int DownCount { get; set; }
        public int HoldCount { get; set; }
        public int BCount { get; set; }
        public int SCount { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double LastBuy { get; set; }
        public double LastSell { get; set; }
        public double BAmount { get; set; }
        public double SAmount { get; set; }

        public Report()
        {
            Date = DateTime.Now;
        }
    }
}
