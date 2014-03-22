using System;
using System.Text;
using System.Windows.Forms;

namespace Calc
{
    /// <summary>
    /// User interface for calculator.
    /// </summary>
    public partial class CalculatorForm : Form
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public CalculatorForm()
        {
            InitializeComponent();
            calculator = new Calculator();
        }

        /// <summary>
        /// Method on click operand button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperandOneClick(object sender, EventArgs e)
        {
            Button ourButton = sender as Button;
            this.activTextBox.AppendText(ourButton.Text);
        }

        /// <summary>
        /// Method on click operator button. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperatorOneClick(object sender, EventArgs e)
        {
            Button ourButton = sender as Button;
            if (activTextBox.TextLength == 0)
            {
                this.passivTextBox.Select(this.passivTextBox.TextLength - 3, 3);
                this.passivTextBox.ReadOnly = false;
                this.passivTextBox.SelectedText = "";
                this.passivTextBox.ReadOnly = true;
                passivTextBox.AppendText(activTextBox.Text + " " + ourButton.Text + " ");
                activTextBox.Clear();
                try
                {
                    calculator.AddOperator(ourButton.Text);
                }
                catch (DivideByZeroException failException)
                {
                    this.passivTextBox.Clear();
                    this.activTextBox.Clear();
                    calculator.Clear();
                    MessageBox.Show("DiVide By ZeRo!!", "Error");
                }
            }
            else
            {
                calculator.AddOperand(Convert.ToDouble(activTextBox.Text));
                passivTextBox.AppendText(activTextBox.Text + " " + ourButton.Text + " ");
                activTextBox.Clear();
                try
                {
                    calculator.AddOperator(ourButton.Text);
                }
                catch (DivideByZeroException failException)
                {
                    this.passivTextBox.Clear();
                    this.activTextBox.Clear();
                    calculator.Clear();
                    MessageBox.Show("DiVide By ZeRo!!", "Error");
                }
            }
        }

        /// <summary>
        /// Method on click "=" button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Result(object sender, EventArgs e)
        {
            if (activTextBox.TextLength == 0)
            {
                return;
            }
            calculator.AddOperand(Convert.ToDouble(activTextBox.Text));
            passivTextBox.Clear();
            activTextBox.Clear();
            try
            {
                activTextBox.AppendText(Convert.ToString(calculator.Result()));
            }
            catch (DivideByZeroException exception)
            {
                this.passivTextBox.Clear();
                this.activTextBox.Clear();
                calculator.Clear();
                MessageBox.Show("DiVide By ZeRo!!", "Error");
            }
        }

        /// <summary>
        /// Method on click "CE" button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearEntryButtomClick(object sender, EventArgs e)
        {
            this.passivTextBox.Clear();
            this.activTextBox.Clear();
            calculator.Clear();
        }

        /// <summary>
        /// Method on click "C" button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButtomClick(object sender, EventArgs e)
        {
            if (this.activTextBox.TextLength != 0)
            {
                this.activTextBox.Select(this.activTextBox.TextLength - 1, 1);
                this.activTextBox.ReadOnly = false;
                this.activTextBox.SelectedText = "";
                this.activTextBox.ReadOnly = true;
            }
        }
        private Calculator calculator;
    }
}
