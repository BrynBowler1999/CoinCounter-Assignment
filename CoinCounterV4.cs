using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MyDialogs;

namespace Coin_Counter
{
    public partial class MoneyCreditCounterV5 : Form
    {
        public MoneyCreditCounterV5()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_TwoPound_Click(object sender, EventArgs e)
        {
            double TwoPound = double.Parse(label_TwoPoundTotal.Text);
            TwoPound = TwoPound + 2.00;
            label_TwoPoundTotal.Text = TwoPound.ToString();
            TwoPound++;

            int TwoPoundLabel = int.Parse(label_TwoPoundCount.Text);
            TwoPoundLabel = TwoPoundLabel + 1;
            label_TwoPoundCount.Text = TwoPoundLabel.ToString();
            TwoPoundLabel++;

            double Total;
            Total = (double.Parse(label_TwoPoundTotal.Text) + double.Parse(label_OnePoundTotal.Text) + double.Parse(label_FiftyPenceTotal.Text) + double.Parse(label_TwentyPenceTotal.Text) + double.Parse(label_TenPenceTotal.Text) + double.Parse(label_FivePenceTotal.Text) + double.Parse(label_TwoPenceTotal.Text) + double.Parse(label_OnePenceTotal.Text));

            textbox_Total.Text = Total.ToString();

            double PenceTotal;
            PenceTotal = ((double.Parse(label_TwoPoundTotal.Text) * 100) + (double.Parse(label_OnePoundTotal.Text) * 100) + (double.Parse(label_FiftyPenceTotal.Text) * 100) + (double.Parse(label_TwentyPenceTotal.Text) * 100) + (double.Parse(label_TenPenceTotal.Text) * 100) + (double.Parse(label_FivePenceTotal.Text) * 100) + (double.Parse(label_TwoPenceTotal.Text) * 100) + (double.Parse(label_OnePenceTotal.Text) * 100));
            textbox_TotalPence.Text = PenceTotal.ToString();
        }

        private void btn_OnePound_Click(object sender, EventArgs e)
        {
            double OnePound = double.Parse(label_OnePoundTotal.Text);
            OnePound = OnePound + 1.00;
            label_OnePoundTotal.Text = OnePound.ToString();
            OnePound++;

            int OnePoundLabel = int.Parse(label_OnePoundCount.Text);
            OnePoundLabel = OnePoundLabel + 1;
            label_OnePoundCount.Text = OnePoundLabel.ToString();
            OnePoundLabel++;

            double Total;
            Total = (double.Parse(label_TwoPoundTotal.Text) + double.Parse(label_OnePoundTotal.Text) + double.Parse(label_FiftyPenceTotal.Text) + double.Parse(label_TwentyPenceTotal.Text) + double.Parse(label_TenPenceTotal.Text) + double.Parse(label_FivePenceTotal.Text) + double.Parse(label_TwoPenceTotal.Text) + double.Parse(label_OnePenceTotal.Text));
            textbox_Total.Text = Total.ToString();

            double PenceTotal;
            PenceTotal = ((double.Parse(label_TwoPoundTotal.Text) * 100) + (double.Parse(label_OnePoundTotal.Text) * 100) + (double.Parse(label_FiftyPenceTotal.Text) * 100) + (double.Parse(label_TwentyPenceTotal.Text) * 100) + (double.Parse(label_TenPenceTotal.Text) * 100) + (double.Parse(label_FivePenceTotal.Text) * 100) + (double.Parse(label_TwoPenceTotal.Text) * 100) + (double.Parse(label_OnePenceTotal.Text) * 100));
            textbox_TotalPence.Text = PenceTotal.ToString();
        }

        private void btn_FiftyPence_Click(object sender, EventArgs e)
        {
            double FiftyPence = double.Parse(label_FiftyPenceTotal.Text);
            FiftyPence = FiftyPence + 0.50;
            label_FiftyPenceTotal.Text = FiftyPence.ToString();
            

            int FiftyPenceLabel = int.Parse(label_FiftyPenceCount.Text);
            FiftyPenceLabel = FiftyPenceLabel + 1;
            label_FiftyPenceCount.Text = FiftyPenceLabel.ToString();
            FiftyPenceLabel++;

            double Total;
            Total = (double.Parse(label_TwoPoundTotal.Text) + double.Parse(label_OnePoundTotal.Text) + double.Parse(label_FiftyPenceTotal.Text) + double.Parse(label_TwentyPenceTotal.Text) + double.Parse(label_TenPenceTotal.Text) + double.Parse(label_FivePenceTotal.Text) + double.Parse(label_TwoPenceTotal.Text) + double.Parse(label_OnePenceTotal.Text));
            textbox_Total.Text = Total.ToString();

            double PenceTotal;
            PenceTotal = ((double.Parse(label_TwoPoundTotal.Text) * 100) + (double.Parse(label_OnePoundTotal.Text) * 100) + (double.Parse(label_FiftyPenceTotal.Text) * 100) + (double.Parse(label_TwentyPenceTotal.Text) * 100) + (double.Parse(label_TenPenceTotal.Text) * 100) + (double.Parse(label_FivePenceTotal.Text) * 100) + (double.Parse(label_TwoPenceTotal.Text) * 100) + (double.Parse(label_OnePenceTotal.Text) * 100));
            textbox_TotalPence.Text = PenceTotal.ToString();
        }

        private void btn_TwentyPence_Click(object sender, EventArgs e)
        {
            double TwentyPence = double.Parse(label_TwentyPenceTotal.Text);
            TwentyPence = TwentyPence + 0.20;
            label_TwentyPenceTotal.Text = TwentyPence.ToString();
            TwentyPence++;

            int TwentyPenceLabel = int.Parse(label_TwentyPenceCount.Text);
            TwentyPenceLabel = TwentyPenceLabel + 1;
            label_TwentyPenceCount.Text = TwentyPenceLabel.ToString();
            TwentyPenceLabel++;

            double Total;
            Total = (double.Parse(label_TwoPoundTotal.Text) + double.Parse(label_OnePoundTotal.Text) + double.Parse(label_FiftyPenceTotal.Text) + double.Parse(label_TwentyPenceTotal.Text) + double.Parse(label_TenPenceTotal.Text) + double.Parse(label_FivePenceTotal.Text) + double.Parse(label_TwoPenceTotal.Text) + double.Parse(label_OnePenceTotal.Text));
            textbox_Total.Text = Total.ToString();

            double PenceTotal;
            PenceTotal = ((double.Parse(label_TwoPoundTotal.Text) * 100) + (double.Parse(label_OnePoundTotal.Text) * 100) + (double.Parse(label_FiftyPenceTotal.Text) * 100) + (double.Parse(label_TwentyPenceTotal.Text) * 100) + (double.Parse(label_TenPenceTotal.Text) * 100) + (double.Parse(label_FivePenceTotal.Text) * 100) + (double.Parse(label_TwoPenceTotal.Text) * 100) + (double.Parse(label_OnePenceTotal.Text) * 100));
            textbox_TotalPence.Text = PenceTotal.ToString();
        }

        private void btn_TenPence_Click(object sender, EventArgs e)
        {
            double TenPence = double.Parse(label_TenPenceTotal.Text);
            TenPence = TenPence + 0.10;
            label_TenPenceTotal.Text = TenPence.ToString();
            TenPence++;

            int TenPenceLabel = int.Parse(label_TenPenceCount.Text);
            TenPenceLabel = TenPenceLabel + 1;
            label_TenPenceCount.Text = TenPenceLabel.ToString();
            TenPenceLabel++;

            double Total;
            Total = (double.Parse(label_TwoPoundTotal.Text) + double.Parse(label_OnePoundTotal.Text) + double.Parse(label_FiftyPenceTotal.Text) + double.Parse(label_TwentyPenceTotal.Text) + double.Parse(label_TenPenceTotal.Text) + double.Parse(label_FivePenceTotal.Text) + double.Parse(label_TwoPenceTotal.Text) + double.Parse(label_OnePenceTotal.Text));
            textbox_Total.Text = Total.ToString();

            double PenceTotal;
            PenceTotal = ((double.Parse(label_TwoPoundTotal.Text) * 100) + (double.Parse(label_OnePoundTotal.Text) * 100) + (double.Parse(label_FiftyPenceTotal.Text) * 100) + (double.Parse(label_TwentyPenceTotal.Text) * 100) + (double.Parse(label_TenPenceTotal.Text) * 100) + (double.Parse(label_FivePenceTotal.Text) * 100) + (double.Parse(label_TwoPenceTotal.Text) * 100) + (double.Parse(label_OnePenceTotal.Text) * 100));
            textbox_TotalPence.Text = PenceTotal.ToString();
        }

        private void btn_FivePence_Click(object sender, EventArgs e)
        {
            double FivePence = double.Parse(label_FivePenceTotal.Text);
            FivePence = FivePence + 0.05;
            label_FivePenceTotal.Text = FivePence.ToString();
            FivePence++;

            int FivePenceLabel = int.Parse(label_FivePenceCount.Text);
            FivePenceLabel = FivePenceLabel + 1;
            label_FivePenceCount.Text = FivePenceLabel.ToString();
            FivePenceLabel++;

            double Total;
            Total = (double.Parse(label_TwoPoundTotal.Text) + double.Parse(label_OnePoundTotal.Text) + double.Parse(label_FiftyPenceTotal.Text) + double.Parse(label_TwentyPenceTotal.Text) + double.Parse(label_TenPenceTotal.Text) + double.Parse(label_FivePenceTotal.Text) + double.Parse(label_TwoPenceTotal.Text) + double.Parse(label_OnePenceTotal.Text));
            textbox_Total.Text = Total.ToString();

            double PenceTotal;
            PenceTotal = ((double.Parse(label_TwoPoundTotal.Text) * 100) + (double.Parse(label_OnePoundTotal.Text) * 100) + (double.Parse(label_FiftyPenceTotal.Text) * 100) + (double.Parse(label_TwentyPenceTotal.Text) * 100) + (double.Parse(label_TenPenceTotal.Text) * 100) + (double.Parse(label_FivePenceTotal.Text) * 100) + (double.Parse(label_TwoPenceTotal.Text) * 100) + (double.Parse(label_OnePenceTotal.Text) * 100));
            textbox_TotalPence.Text = PenceTotal.ToString();
        }

        private void btn_TwoPence_Click(object sender, EventArgs e)
        {
            double TwoPence = double.Parse(label_TwoPenceTotal.Text);
            TwoPence = TwoPence + 0.02;
            label_TwoPenceTotal.Text = TwoPence.ToString();


            int TwoPenceLabel = int.Parse(label_TwoPenceCount.Text);
            TwoPenceLabel = TwoPenceLabel + 1;
            label_TwoPenceCount.Text = TwoPenceLabel.ToString();
            TwoPenceLabel++;

            double Total;
            Total = (double.Parse(label_TwoPoundTotal.Text) + double.Parse(label_OnePoundTotal.Text) + double.Parse(label_FiftyPenceTotal.Text) + double.Parse(label_TwentyPenceTotal.Text) + double.Parse(label_TenPenceTotal.Text) + double.Parse(label_FivePenceTotal.Text) + double.Parse(label_TwoPenceTotal.Text));
            textbox_Total.Text = Total.ToString();

            double PenceTotal;
            PenceTotal = ((double.Parse(label_TwoPoundTotal.Text) * 100) + (double.Parse(label_OnePoundTotal.Text) * 100) + (double.Parse(label_FiftyPenceTotal.Text) * 100) + (double.Parse(label_TwentyPenceTotal.Text) * 100) + (double.Parse(label_TenPenceTotal.Text) * 100) + (double.Parse(label_FivePenceTotal.Text) * 100) + (double.Parse(label_TwoPenceTotal.Text) * 100) + (double.Parse(label_OnePenceTotal.Text) * 100));
            textbox_TotalPence.Text = PenceTotal.ToString();
        }

        private void btn_OnePence_Click(object sender, EventArgs e)
        {
            
            double OnePence = double.Parse(label_OnePenceTotal.Text);
            OnePence = OnePence + 0.01;
            label_OnePenceTotal.Text = OnePence.ToString();

            int OnePenceLabel = int.Parse(label_OnePenceCount.Text);
            OnePenceLabel = OnePenceLabel + 1;
            label_OnePenceCount.Text = OnePenceLabel.ToString();
            OnePenceLabel++;

            double Total;
            Total = (double.Parse(label_TwoPoundTotal.Text) + double.Parse(label_OnePoundTotal.Text) + double.Parse(label_FiftyPenceTotal.Text) + double.Parse(label_TwentyPenceTotal.Text) + double.Parse(label_TenPenceTotal.Text) + double.Parse(label_FivePenceTotal.Text) + double.Parse(label_TwoPenceTotal.Text) + double.Parse(label_OnePenceTotal.Text));
            String.Format("{0:n2}", Convert.ToDouble(label_OnePenceTotal.Text));
            textbox_Total.Text = Total.ToString();

            double PenceTotal;
            PenceTotal = ((double.Parse(label_TwoPoundTotal.Text) * 100) + (double.Parse(label_OnePoundTotal.Text) * 100) + (double.Parse(label_FiftyPenceTotal.Text) * 100) + (double.Parse(label_TwentyPenceTotal.Text) * 100) + (double.Parse(label_TenPenceTotal.Text) * 100) + (double.Parse(label_FivePenceTotal.Text) * 100) + (double.Parse(label_TwoPenceTotal.Text) * 100) + (double.Parse(label_OnePenceTotal.Text) * 100));
            textbox_TotalPence.Text = PenceTotal.ToString();
        }
    }
}