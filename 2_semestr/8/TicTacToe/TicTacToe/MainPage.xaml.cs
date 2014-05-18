using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using KR;

namespace TicTacToe
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
            game = new Game(new GamePlace(new User("X"), new Computer("O"), 3));
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            Button ourButton = sender as Button;
            if (ourButton.Content != "")
            {
                return;
            }
            if (ourButton.TabIndex < 3)
            {
                IPlayer temp = game.MakeStep(1, 0, ourButton.TabIndex % 3);
                ourButton.Content = "X";
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
                button1.Content = game.matrixOfGame[0, 0];
                button2.Content = game.matrixOfGame[0, 1];
                button3.Content = game.matrixOfGame[0, 2];
                button4.Content = game.matrixOfGame[1, 0];
                button5.Content = game.matrixOfGame[1, 1];
                button6.Content = game.matrixOfGame[1, 2];
                button7.Content = game.matrixOfGame[2, 0];
                button8.Content = game.matrixOfGame[2, 1];
                button9.Content = game.matrixOfGame[2, 2];
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
                ourButton.Content = "X";
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
                button1.Content = game.matrixOfGame[0, 0];
                button2.Content = game.matrixOfGame[0, 1];
                button3.Content = game.matrixOfGame[0, 2];
                button4.Content = game.matrixOfGame[1, 0];
                button5.Content = game.matrixOfGame[1, 1];
                button6.Content = game.matrixOfGame[1, 2];
                button7.Content = game.matrixOfGame[2, 0];
                button8.Content = game.matrixOfGame[2, 1];
                button9.Content = game.matrixOfGame[2, 2];
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
                ourButton.Content = "X";
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
                button1.Content = game.matrixOfGame[0, 0];
                button2.Content = game.matrixOfGame[0, 1];
                button3.Content = game.matrixOfGame[0, 2];
                button4.Content = game.matrixOfGame[1, 0];
                button5.Content = game.matrixOfGame[1, 1];
                button6.Content = game.matrixOfGame[1, 2];
                button7.Content = game.matrixOfGame[2, 0];
                button8.Content = game.matrixOfGame[2, 1];
                button9.Content = game.matrixOfGame[2, 2];
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
            button1.Content = "";
            button2.Content = "";
            button3.Content = "";
            button4.Content = "";
            button5.Content = "";
            button6.Content = "";
            button7.Content = "";
            button8.Content = "";
            button9.Content = "";
        }
        private Game game;
    }
}
