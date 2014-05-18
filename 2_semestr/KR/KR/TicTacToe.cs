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
        private Game game;

        public TicTacToe()
        {
            InitializeComponent();
            game = new Game(new GamePlace(new User("X"), new Computer("O"), 3));
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button ourButton = sender as Button;
            if (ourButton.TabIndex < 3)
            {
                IPlayer temp = game.MakeStep(1, 0, ourButton.TabIndex % 3);
                ourButton.Text = "X";
                if (temp == null)
                {
                    MessageBox.Show("Winner is " + temp.Symbol);
                    clearAllKeys();
                    game.Clear();
                    return;
                }
                if (game.IsFull())
                {
                    MessageBox.Show("Null result");
                    clearAllKeys();
                    game.Clear();
                    return;
                }
                temp = game.MakeStep(0, 0, ourButton.TabIndex % 3);
                button1.Text = game.matrixOfGame[0, 0];
                button2.Text = game.matrixOfGame[0, 1];
                button3.Text = game.matrixOfGame[0, 2];
                button4.Text = game.matrixOfGame[1, 0];
                button5.Text = game.matrixOfGame[1, 1];
                button6.Text = game.matrixOfGame[1, 2];
                button7.Text = game.matrixOfGame[2, 0];
                button8.Text = game.matrixOfGame[2, 1];
                button9.Text = game.matrixOfGame[2, 2];
                if (temp == null)
                {
                    MessageBox.Show("Winner is " + temp.Symbol);
                    clearAllKeys();
                    game.Clear();
                    return;
                }
                if (game.IsFull())
                {
                    MessageBox.Show("Null result");
                    clearAllKeys();
                    game.Clear();
                    return;
                }
            }
            else if (ourButton.TabIndex < 6)
            {
                IPlayer temp = game.MakeStep(1, 1, ourButton.TabIndex % 3);
                ourButton.Text = "X";
                if (temp == null)
                {
                    MessageBox.Show("Winner is " + "X");
                    clearAllKeys();
                    game.Clear();
                    return;
                }
                if (game.IsFull())
                {
                    MessageBox.Show("Null result");
                    clearAllKeys();
                    game.Clear();
                    return;
                }
                temp = game.MakeStep(0, 0, ourButton.TabIndex % 3);
                button1.Text = game.matrixOfGame[0, 0];
                button2.Text = game.matrixOfGame[0, 1];
                button3.Text = game.matrixOfGame[0, 2];
                button4.Text = game.matrixOfGame[1, 0];
                button5.Text = game.matrixOfGame[1, 1];
                button6.Text = game.matrixOfGame[1, 2];
                button7.Text = game.matrixOfGame[2, 0];
                button8.Text = game.matrixOfGame[2, 1];
                button9.Text = game.matrixOfGame[2, 2];
                if (temp == null)
                {
                    MessageBox.Show("Winner is " + "O");
                    clearAllKeys();
                    game.Clear();
                    return;
                }
                if (game.IsFull())
                {
                    MessageBox.Show("Null result");
                    clearAllKeys();
                    game.Clear();
                    return;
                }
            }
            else
            {
                IPlayer temp = game.MakeStep(1, 2, ourButton.TabIndex % 3);
                ourButton.Text = "X";
                if (temp == null)
                {
                    MessageBox.Show("Winner is " + "X");
                    clearAllKeys();
                    game.Clear();
                    return;
                }
                if (game.IsFull())
                {
                    MessageBox.Show("Null result");
                    clearAllKeys();
                    game.Clear();
                    return;
                }
                temp = game.MakeStep(0, 0, ourButton.TabIndex % 3);
                button1.Text = game.matrixOfGame[0, 0];
                button2.Text = game.matrixOfGame[0, 1];
                button3.Text = game.matrixOfGame[0, 2];
                button4.Text = game.matrixOfGame[1, 0];
                button5.Text = game.matrixOfGame[1, 1];
                button6.Text = game.matrixOfGame[1, 2];
                button7.Text = game.matrixOfGame[2, 0];
                button8.Text = game.matrixOfGame[2, 1];
                button9.Text = game.matrixOfGame[2, 2];
                if (temp == null)
                {
                    MessageBox.Show("Winner is " + "O");
                    clearAllKeys();
                    game.Clear();
                    return;
                }
                if (game.IsFull())
                {
                    MessageBox.Show("Null result");
                    clearAllKeys();
                    game.Clear();
                    return;
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

        private void tableLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
