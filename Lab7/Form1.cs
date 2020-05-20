using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SevenButtom_Click(object sender, EventArgs e)
        {
            ScreenTextBox.Text += "7";
        }

        private void EightButtom_Click(object sender, EventArgs e)
        {
            ScreenTextBox.Text += "8";
        }

        private void NineButtom_Click(object sender, EventArgs e)
        {
            ScreenTextBox.Text += "9";
        }

        private void FourButtom_Click(object sender, EventArgs e)
        {
            ScreenTextBox.Text += "4";
        }

        private void FiveButtom_Click(object sender, EventArgs e)
        {
            ScreenTextBox.Text += "5";
        }

        private void SixButtom_Click(object sender, EventArgs e)
        {
            ScreenTextBox.Text += "6";
        }

        private void OneButtom_Click(object sender, EventArgs e)
        {
            ScreenTextBox.Text += "1";
        }

        private void TwoButtom_Click(object sender, EventArgs e)
        {
            ScreenTextBox.Text += "2";
        }

        private void ThreeButtom_Click(object sender, EventArgs e)
        {
            ScreenTextBox.Text += "3";
        }

        private void ZeroButtom_Click(object sender, EventArgs e)
        {
            ScreenTextBox.Text += "0";
        }

        private void DelButtom_Click(object sender, EventArgs e)
        {
            ScreenTextBox.Text = ScreenTextBox.Text.Remove(ScreenTextBox.Text.Length - 1);
        }



        private void AnsButtom_Click(object sender, EventArgs e)
        {

        }

        private void EqualButtom_Click(object sender, EventArgs e)
        {
            ScreenTextBox.Clear();
        }

        private void MultiplyButtom_Click(object sender, EventArgs e)
        {
            ScreenTextBox.Text += "x";
        }

        private void DivideButtom_Click(object sender, EventArgs e)
        {
            ScreenTextBox.Text += "/";
        }

        private void SumButtom_Click(object sender, EventArgs e)
        {
            ScreenTextBox.Text += "+";
        }

        private void RestButtom_Click(object sender, EventArgs e)
        {
            ScreenTextBox.Text += "-";
        }

        private void ClearButtom_Click(object sender, EventArgs e)
        {
            ScreenTextBox.Clear();
        }
    }
}
