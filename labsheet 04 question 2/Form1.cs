
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LabelOperation_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(Num1.Text);
            double num2 = double.Parse(Num2.Text);

            // Get the selected operation based on radio button state
            string operation = "";
            if (radioButtonAdd.Checked)
            {
                operation = "+";
            }
            else if (radioButtonSubtract.Checked)
            {
                operation = "-";
            }
            else if (radioButtonMultiply.Checked)
            {
                operation = "*";
            }
            else if (radioButtonDivide.Checked)
            {
                operation = "/";
            }
            else
            {
                MessageBox.Show("Please select an operation.");
                return;  // Exit if no operation is selected
            }

            // Perform calculation based on operation
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        MessageBox.Show("Division by zero is not allowed.");
                    }
                    else
                    {
                        result = num1 / num2;
                    }
                    break;
            }
        }
    }