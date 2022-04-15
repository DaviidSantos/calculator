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
            displayNumber(btZero.Text, result);
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

        private void btInvert_Click(object sender, EventArgs e)
        {

        }

        private int displayNumber(string numberPressed, double result)
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
            return 0;
        }
    }
}
