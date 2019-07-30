using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace BitCoin
{
    public partial class Main : Form
    {
        private List<Report> reports;
        private Thread mainThread;

        public Main()
        {
            reports = new List<Report>();

            InitializeComponent();

            //create and start a new thread in the load event.
            //passing it a method to be run on the new thread.
            mainThread = new Thread(CheckChanges);
            mainThread.Start();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void UpdateTable()
        {
            txtTrades.Text = "Loading";
            btnRefresh.Enabled = false;

            var helper = new BitcoinApiHelper();
            var trades = helper.GetTrades().Result;

            txtTrades.Text = "";

            double lastPrice = 0;
            double high = 0, low = 9999999;
            double lastBuy = 0, lastSell = 0;
            ChangeType type = ChangeType.hold;
            string txt = "";
            string diff = "";
            int count = 0;
            int upCount = 0, downCount = 0, holdCount = 0;
            int bCount = 0, sCount = 0;
            double bAmount = 0, sAmount = 0;

            foreach (var t in trades)
            {
                txt = t.type + " - " + t.amount.ToString("0.00000000") + " - " + t.price + "\r\n" + txt;

                if (t.price > lastPrice)
                {
                    count = type == ChangeType.up ? count + 1 : 1;
                    type = ChangeType.up;

                    diff = count + "x " + ChangeType.up.ToString();
                    upCount++;
                }
                else if (t.price < lastPrice)
                {
                    count = type == ChangeType.down ? count + 1 : 1;
                    type = ChangeType.down;

                    diff = count + "x " + ChangeType.down.ToString();
                    downCount++;
                }
                else
                {
                    count = type == ChangeType.hold ? count + 1 : 1;
                    type = ChangeType.hold;

                    diff = count + "x " + ChangeType.hold.ToString();
                    holdCount++;
                }


                bCount = t.type == "buy" ? bCount + 1 : bCount; 
                sCount = t.type == "sell" ? sCount + 1 : sCount;

                high = high > t.price ? high : t.price;
                low = low < t.price ? low : t.price;

                lastBuy = t.type == "buy" ? t.price : lastBuy;
                lastSell = t.type == "sell" ? t.price : lastSell;

                bAmount = t.type == "buy" ? bAmount + t.amount : bAmount;
                sAmount = t.type == "sell" ? sAmount + t.amount : sAmount;

                lastPrice = t.price;
            }

            txtTrades.Text = txt;
            lblDiff.Text = diff;
            lblCounts.Text = "U: " + upCount + " " +
                             "D: " + downCount + " " +
                             "H: " + holdCount ;
            lblBCount.Text = "B: " + bCount;
            lblSCount.Text = "S: " + sCount;
            lblHigh.Text = "H: " + high.ToString("0.00");
            lblLow.Text = "L: " + low.ToString("0.00");
            lblLast.Text = "B: " + lastBuy.ToString("0.00");
            lblLastSell.Text = "S: " + lastSell.ToString("0.00");
            lblBAmount.Text = "BA: " + bAmount;
            lblSAmount.Text = "SA: " + sAmount;

            var rep = new Report
            {
                UpCount = upCount,
                DownCount = downCount,
                HoldCount = holdCount,
                BCount = bCount,
                SCount = sCount,
                High = high,
                Low = low,
                LastBuy = lastBuy,
                LastSell = lastSell,
                Trades = trades,
                BAmount = bAmount,
                SAmount = sAmount,
            };

            UpdateDiff(rep);

            reports.Add(rep);

            btnRefresh.Enabled = true;
        }

        private void UpdateDiff(Report newRep)
        {
            if (reports.Count < 1) return;

            var oldRep = reports.Last();

            lblRLast.Text = (oldRep.LastBuy - newRep.LastBuy).ToString("0.00");
            lblRLastSell.Text = (oldRep.LastSell - newRep.LastSell).ToString("0.00");
            lblRBCount.Text = (oldRep.BCount - newRep.BCount).ToString();
            lblRSCount.Text = (oldRep.SCount - newRep.SCount).ToString();
            lblRBAmo.Text = (oldRep.BAmount - newRep.BAmount).ToString();
            lblRSAmo.Text = (oldRep.SAmount - newRep.SAmount).ToString();
            lblRHigh.Text = (oldRep.High - newRep.High).ToString("0.00");
            lblRLow.Text = (oldRep.Low - newRep.Low).ToString("0.00");
        }

        private void CheckChanges()
        {
            while (true)
            {
                //you need to use Invoke because the new thread can't access the UI elements directly
                MethodInvoker mi = delegate () { UpdateTable(); };
                Thread.Sleep(1000);

                Invoke(mi);

                Thread.Sleep(10000);
            }
        }
    }

    public enum ChangeType
    {
        hold,
        up,
        down
    }
}
