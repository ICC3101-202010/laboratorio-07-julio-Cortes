using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        bool operationmade = false;
        double result = 0;
        string operation = "";
        bool pointender=false;
        bool equal = false;
        string ans = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click_Operators(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            if (equal)
            {
                ScreenTextBox.Text = "0";
                GeneralScreenBox.Text = result.ToString()+operation;

            }
            if (!operationmade&&!equal)
            {
                GeneralScreenBox.Text += ScreenTextBox.Text + operation;

            }

            result = double.Parse(ScreenTextBox.Text);
            operationmade = true;
            equal = false;


        }

        private void button_Click_Numbers(object sender, EventArgs e)
        {

            if (equal)
            {
                result = 0;
                GeneralScreenBox.Clear();
                ScreenTextBox.Clear();
            }
            Button button = (Button)sender;
            if (operationmade)
            {
                ScreenTextBox.Clear();
            }
            if (button.Text == "." && ScreenTextBox.Text.Contains(".") || ScreenTextBox.Text == "0" && button.Text == "0")
            {

            }
            else if (button.Name == "AnsButtom")
            {
                ScreenTextBox.Text = ans;
            }
            else if (button.Text == ".")
            {
                ScreenTextBox.Text += ",";
                pointender = true;
            }
            else if (ScreenTextBox.Text == "0")
            {
                ScreenTextBox.Text = button.Text;
                pointender = false;
            }
            else
            {
                ScreenTextBox.Text += button.Text;
                pointender = false;
            }
            
            operationmade = false;
            equal = false;



        }

        private void ClearButtom_Click(object sender, EventArgs e)
        {
            ScreenTextBox.Text = "0";
            GeneralScreenBox.Text = "";
            result = 0;
        }

        private void DelButtom_Click(object sender, EventArgs e)
        {
            if (equal)
            {
                result = 0;
                GeneralScreenBox.Text = "";
            }
            ScreenTextBox.Text = "0";
        }

        private void EqualButtom_Click(object sender, EventArgs e)
        {
            if (pointender)
            {
                ScreenTextBox.Text = "Syntax.Error";
                GeneralScreenBox.Clear();
            }
            else if (!operationmade)
            {
                GeneralScreenBox.Text += ScreenTextBox.Text;
                switch (operation)
                {
                    case "+":
                        ScreenTextBox.Text = (result + double.Parse(ScreenTextBox.Text)).ToString();
                        break;
                    case "-":
                        ScreenTextBox.Text = (result - double.Parse(ScreenTextBox.Text)).ToString();
                        break;
                    case "x":
                        ScreenTextBox.Text = (result * double.Parse(ScreenTextBox.Text)).ToString();
                        break;
                    case "/":
                        if (double.Parse(ScreenTextBox.Text) == 0)
                        {
                            ScreenTextBox.Text = "Math.Error";
                            GeneralScreenBox.Clear();

                        }
                        else
                        {
                            ScreenTextBox.Text = (result / double.Parse(ScreenTextBox.Text)).ToString();
                        }

                        break;
                    default:
                        break;
                }
                if (ScreenTextBox.Text != "Math.Error")
                {
                    History.Text += GeneralScreenBox.Text+"=\n";
                    History.Text += ScreenTextBox.Text + "\n";
                    result = double.Parse(ScreenTextBox.Text);
                    ans = result.ToString();
                }

                else
                {
                    result = 0;
                }
                equal = true;

            }

            

        }


    }
}
