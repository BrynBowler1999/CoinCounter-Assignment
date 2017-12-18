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
        }

        private void btn_OnePound_Click(object sender, EventArgs e)
        {
            double OnePound = double.Parse(label_OnePoundTotal.Text);
            OnePound = OnePound + 1.00;
            label_OnePoundTotal.Text = OnePound.ToString();
            OnePound++;
        }

        private void btn_FiftyPence_Click(object sender, EventArgs e)
        {
            double FiftyPence = double.Parse(label_FiftyPenceTotal.Text);
            FiftyPence = FiftyPence + 0.50;
            label_FiftyPenceTotal.Text = FiftyPence.ToString();
            FiftyPence++;
        }

        private void btn_TwentyPence_Click(object sender, EventArgs e)
        {
            double TwentyPence = double.Parse(label_TwentyPenceTotal.Text);
            TwentyPence = TwentyPence + 0.20;
            label_TwentyPenceTotal.Text = TwentyPence.ToString();
            TwentyPence++;
        }

        private void btn_TenPence_Click(object sender, EventArgs e)
        {
            double TenPence = double.Parse(label_TenPenceTotal.Text);
            TenPence = TenPence + 0.10;
            label_TenPenceTotal.Text = TenPence.ToString();
            TenPence++;
        }

        private void btn_FivePence_Click(object sender, EventArgs e)
        {
            double FivePence = double.Parse(label_FivePenceTotal.Text);
            FivePence = FivePence + 0.05;
            label_FivePenceTotal.Text = FivePence.ToString();
            FivePence++;
        }

        private void btn_TwoPence_Click(object sender, EventArgs e)
        {
            double TwoPence = double.Parse(label_TwoPenceTotal.Text);
            TwoPence = TwoPence + 0.02;
            label_TwoPenceTotal.Text = TwoPence.ToString();
            TwoPence++;
        }

        private void btn_OnePence_Click(object sender, EventArgs e)
        {
            
            double OnePence = double.Parse(label_OnePenceTotal.Text);
            OnePence = OnePence + 0.01;
            label_OnePenceTotal.Text = OnePence.ToString();
            OnePence++;
        }
    }
}