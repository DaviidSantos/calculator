using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace calculator
{
    
    public partial class Calculator : Form
    {
        string operation = "";
        double firstNumber = 0;
        double secondNumber = 0;
        double result = 0;

        public Calculator()
        {
            InitializeComponent();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            display.Text = "";
            result = 0;
            firstNumber = 0;
            secondNumber = 0;
            operation = "";
        }

        private void btZero_Click(object sender, EventArgs e)
        {
            displayNumber(btZero.Text, result);
        }

        private void btOne_Click(object sender, EventArgs e)
        {
            displayNumber(btOne.Text, result);
        }

        private void btTwo_Click(object sender, EventArgs e)
        {
            displayNumber(btTwo.Text, result);
        }

        private void btThree_Click(object sender, EventArgs e)
        {
            displayNumber(btThree.Text, result);
        }

        private void btFour_Click(object sender, EventArgs e)
        {
            displayNumber(btFour.Text, result);
        }

        private void btFive_Click(object sender, EventArgs e)
        {
            displayNumber(btFive.Text, result);
        }

        private void btSix_Click(object sender, EventArgs e)
        {
            displayNumber(btSix.Text, result);
        }

        private void btSeven_Click(object sender, EventArgs e)
        {
            displayNumber(btSeven.Text, result);
        }

        private void btEight_Click(object sender, EventArgs e)
        {
            displayNumber(btEight.Text, result);
        }

        private void btNine_Click(object sender, EventArgs e)
        {
            displayNumber(btNine.Text, result);
        }

        private void btPoint_Click(object sender, EventArgs e)
        {
            displayNumber(btPoint.Text, result);
        }

        private void btInvert_Click(object sender, EventArgs e)
        {
            if(display.Text != "")
            {
                double number = double.Parse(display.Text);
                number = number * (-1);
                display.Text = number.ToString();
            }
        }

        private void btPlus_Click(object sender, EventArgs e)
        {

            if (display.Text == "")
            {
                MessageBox.Show("SYNTAX ERROR!");
            }
            else
            {
                if (firstNumber == 0)
                {
                    firstNumber = double.Parse(display.Text);
                }
                else if (operation != "+")
                {
                    firstNumber = Calculate(firstNumber);
                }
                else
                {
                    firstNumber += double.Parse(display.Text);
                }
            }

            operation = "+";
            display.Text = "";
        }

        private void btEqual_Click(object sender, EventArgs e)
        {
            if (operation == "+")
            {
                secondNumber = double.Parse(display.Text);
                result = firstNumber + secondNumber;
                display.Text = result.ToString();
                firstNumber = 0;
            }
            else if (operation == "/")
            {
                secondNumber = double.Parse(display.Text);
                if (secondNumber != 0)
                {
                    result = firstNumber / secondNumber;
                    display.Text = result.ToString();
                    firstNumber = 0;
                }
                else
                {
                    display.Text = "SYNTAX ERROR!";
                }
            }
            else if (operation == "-")
            {
                secondNumber = double.Parse(display.Text);
                result = firstNumber - secondNumber;
                display.Text = result.ToString();
                firstNumber = 0;
            }
            else if (operation == "*")
            {
                secondNumber = double.Parse(display.Text);
                result = firstNumber * secondNumber;
                display.Text = result.ToString();
                firstNumber = 0;
            }
            else if (operation == "%")
            {
                secondNumber = double.Parse(display.Text);
                result = firstNumber * (secondNumber / 100);
                display.Text = result.ToString();
                firstNumber = 0;
            }
        }

        private void btDivision_Click(object sender, EventArgs e)
        {
            if (display.Text == "")
            {
                MessageBox.Show("SYNTAX ERROR!");
            }
            else
            {
                if (firstNumber == 0)
                {
                    firstNumber = double.Parse(display.Text);
                }
                else if (operation != "/")
                {
                    firstNumber = Calculate(firstNumber);
                }
                else
                {
                    firstNumber /= double.Parse(display.Text);
                }
            }

            operation = "/";
            display.Text = "";
        }

        private void btMinus_Click(object sender, EventArgs e)
        {

            if(display.Text == "")
            {
                display.Text = "-";
            }
            else
            {
                if (firstNumber == 0)
                {
                    firstNumber = double.Parse(display.Text);
                }
                else if (operation != "-")
                {
                    firstNumber = Calculate(firstNumber);
                }
                else
                {
                    firstNumber -= double.Parse(display.Text);
                }

                operation = "-";
                display.Text = "";
            }
        }

        private void btMultiplication_Click(object sender, EventArgs e)
        {
            if (display.Text == "")
            {
                MessageBox.Show("SYNTAX ERROR!");
            }
            else
            {
                if (firstNumber == 0)
                {
                    firstNumber = double.Parse(display.Text);
                }
                else if (operation != "*")
                {
                    firstNumber = Calculate(firstNumber);
                }
                else
                {
                    firstNumber *= double.Parse(display.Text);
                }
            }

            operation = "*";
            display.Text = "";
        }

        private void btPercentage_Click(object sender, EventArgs e)
        {
            if (display.Text == "")
            {
                MessageBox.Show("SYNTAX ERROR!");
            }
            else
            {
                if (firstNumber == 0)
                {
                    firstNumber = double.Parse(display.Text);
                }
                else if (operation != "%")
                {
                    firstNumber = Calculate(firstNumber);
                }
                else
                {
                    firstNumber = firstNumber / double.Parse(display.Text) / 100;
                }
            }

            operation = "%";
            display.Text = "";
        }

        private void btSquareRoot_Click(object sender, EventArgs e)
        {
            if (display.Text == "")
            {
                MessageBox.Show("SYNTAX ERROR!");
            }
            else
            {
                if (result == 0)
                {
                    if (firstNumber == 0)
                    {
                        firstNumber = double.Parse(display.Text);
                        result = Math.Sqrt(firstNumber);
                        display.Text = result.ToString();
                    }
                    else
                    {
                        result = Math.Sqrt(firstNumber);
                        display.Text = result.ToString();
                    }
                }
                else
                {
                    result = Math.Sqrt(result);
                    display.Text = result.ToString();
                }
            }
        }
        private void displayNumber(string numberPressed, double result)
        {
            if (result == 0)
            {
                display.Text += numberPressed;
            }
            else
            {
                result = 0;
                display.Text = numberPressed;
            }
        }

        private double Calculate(double firstNumber)
        {
            if (operation == "+")
            {
                double temp1 = double.Parse(display.Text);
                double temp2 = firstNumber + temp1;
                return temp2;
            }
            else if (operation == "-")
            {
                double temp1 = double.Parse(display.Text);
                double temp2 = firstNumber - temp1;
                return temp2;
            }
            else if (operation == "*")
            {
                double temp1 = double.Parse(display.Text);
                double temp2 = firstNumber * temp1;
                return temp2;
            }
            else if (operation == "/")
            {
                double temp1 = double.Parse(display.Text);
                double temp2 = firstNumber / temp1;
                return temp2;
            }
            else if (operation == "%")
            {
                double temp1 = double.Parse(display.Text);
                double temp2 = firstNumber * (temp1/100);
                return temp2;
            }
            return 0;
        }
       
    }
}
