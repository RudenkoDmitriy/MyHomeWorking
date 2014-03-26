using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KR
{
    public partial class TicTacToe : Form
    {
        private XO matrix;

        public TicTacToe()
        {
            InitializeComponent();
            matrix = new XO();

        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button ourButton = sender as Button;
            if (ourButton.TabIndex < 3)
            {
                ourButton.Text = matrix.Add(0, ourButton.TabIndex % 3);
                if (matrix.Result())
                {
                    MessageBox.Show("Winner is " + matrix.lastDownKey);
                    clearAllKeys();
                    matrix.Clear();
                }
                if (matrix.numberOfEnterKeys == 9)
                {
                    MessageBox.Show("Null result");
                    clearAllKeys();
                    matrix.Clear();
                }
            }
            else if (ourButton.TabIndex < 6)
            {
                ourButton.Text = matrix.Add(1, ourButton.TabIndex % 3);
                if (matrix.Result())
                {
                    MessageBox.Show("Winner is " + matrix.lastDownKey);
                    clearAllKeys();
                    matrix.Clear();
                }
                if (matrix.numberOfEnterKeys == 9)
                {
                    MessageBox.Show("Null result");
                    clearAllKeys();
                    matrix.Clear();
                }
            }
            else
            {
                ourButton.Text = matrix.Add(2, ourButton.TabIndex % 3);
                if (matrix.Result())
                {
                    MessageBox.Show("Winner is " + matrix.lastDownKey);
                    clearAllKeys();
                    matrix.Clear();
                }
                if (matrix.numberOfEnterKeys == 9)
                {
                    MessageBox.Show("Null result");
                    clearAllKeys();
                    matrix.Clear();
                }
            }
        }
        public void clearAllKeys()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }
    }
}
