using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR
{
    /// <summary>
    /// Class of game "tic Tac Toe".
    /// </summary>
    public class GamePlace
    {
        public string[,] MatrixOfGame { get; set; }
        public int SizeOfMatrix { get; set; }
        private IPlayer FirstPlayer { get; set; }
        private IPlayer SecondPlayer { get; set; }
        public int NumberOfFull { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        public GamePlace(IPlayer firstPlayer, IPlayer secondPlayer, int sizeOfMatrix)
        {
            SizeOfMatrix = sizeOfMatrix;
            MatrixOfGame = new string[SizeOfMatrix, SizeOfMatrix];
            for (int i = 0; i != SizeOfMatrix; i++)
            {
                for (int j = 0; j != SizeOfMatrix; j++)
                {
                    MatrixOfGame[i,j] = "";
                }
            }
            if (firstPlayer.Symbol == "X")
            {
                FirstPlayer = firstPlayer;
                SecondPlayer = secondPlayer;
            }
            else
            {
                FirstPlayer = secondPlayer;
                SecondPlayer = firstPlayer;
            }
        }

        /// <summary>
        /// Add new symbol to cell by input coordinates.
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="columnIndex"></param>
        /// <returns></returns>
        public IPlayer MakeFirstStep(int rowIndex, int columnIndex)
        {
            NumberOfFull++;
            if (MatrixOfGame[rowIndex, columnIndex] == "")
            {
                    FirstPlayer.MakeStep(rowIndex, columnIndex, MatrixOfGame, SizeOfMatrix);
                    if (Result())
                    {
                        return null;
                    }
            }
            return FirstPlayer;
        }

        /// <summary>
        /// Add new symbol to cell by input coordinates.
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="columnIndex"></param>
        /// <returns></returns>
        public IPlayer MakeSecondStep(int rowIndex, int columnIndex)
        {
            NumberOfFull++;
            SecondPlayer.MakeStep(rowIndex, columnIndex, MatrixOfGame, SizeOfMatrix);
            if (Result())
            {
                return null;
            }
            
            return SecondPlayer;
        }

        /// <summary>
        /// Check result of game.
        /// </summary>
        /// <returns></returns>
        public bool Result()
        {
            for (int i = 0; i != SizeOfMatrix; i++)
            {
                bool temp = false;
                for (int j = 0; j != SizeOfMatrix - 1; j++)
                {
                    if (MatrixOfGame[i, j] == MatrixOfGame[i, j + 1] && MatrixOfGame[i, j + 1] != "")
                    {
                        temp = true;
                    }
                    else
                    {
                        temp = false;
                        break;
                    }
                }
                if (temp)
                {
                    return true;
                }
            }
            for (int i = 0; i != SizeOfMatrix; i++)
            {
                bool temp = false;
                for (int j = 0; j != SizeOfMatrix - 1; j++)
                {
                    if (MatrixOfGame[j, i] == MatrixOfGame[j + 1, i] && MatrixOfGame[j + 1, i] != "")
                    {
                        temp = true;
                    }
                    else
                    {
                        temp = false;
                        break;
                    }
                }
                if (temp)
                {
                    return true;
                }
            }
            bool temporary = false;
            for (int i = 0; i != SizeOfMatrix - 1; i++)
            {
                if (MatrixOfGame[i, i] == MatrixOfGame[i + 1, i + 1] && MatrixOfGame[i + 1, i + 1] != "")
                {
                    temporary = true;
                }
                else
                {
                    temporary = false;
                    break;
                }
            }
            if (temporary)
            {
                return true;
            }
            temporary = false;
            for (int i = 0; i != SizeOfMatrix - 1; i++)
            {
                if (MatrixOfGame[i, SizeOfMatrix - 1 - i] == MatrixOfGame[i + 1, SizeOfMatrix - i - 2] &&  MatrixOfGame[i + 1, SizeOfMatrix - i - 2] != "")
                {
                    temporary = true;
                }
                else
                {
                    temporary = false;
                    break;
                }
            }
            if (temporary)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Clear game matrix.
        /// </summary>
        public void Clear()
        {
            for (int i = 0; i != SizeOfMatrix; i++)
            {
                for (int j = 0; j != SizeOfMatrix; j++)
                {
                    MatrixOfGame[i, j] = "";
                }
            }
            NumberOfFull = 0;
        }
    }
}
