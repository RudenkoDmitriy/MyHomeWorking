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
    public class XO
    {
        private string[,] matrixOfGame;
        private bool testOnNextDownKey;
        public string lastDownKey { get; set; }
        public int numberOfEnterKeys { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        public XO()
        {
            matrixOfGame = new string[3,3];
            for (int i = 0; i != 3; i++)
            {
                for (int j = 0; j != 3; j++)
                {
                    matrixOfGame[i,j] = "Y";
                }
            }
            testOnNextDownKey = false;
        }

        /// <summary>
        /// Add new symbol to cell by input coordinates.
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="columnIndex"></param>
        /// <returns></returns>
        public string Add(int rowIndex, int columnIndex)
        {
            if (matrixOfGame[rowIndex, columnIndex] == "Y")
            {
                if (!testOnNextDownKey)
                {
                    matrixOfGame[rowIndex, columnIndex] = "X";
                    testOnNextDownKey = true;
                    lastDownKey = "X";
                    numberOfEnterKeys++;
                }
                else
                {
                    matrixOfGame[rowIndex, columnIndex] = "O";
                    testOnNextDownKey = false ;
                    lastDownKey = "O";
                    numberOfEnterKeys++;
                }
            }
            return matrixOfGame[rowIndex, columnIndex];
        }

        /// <summary>
        /// Check result of game.
        /// </summary>
        /// <returns></returns>
        public bool Result()
        {
            for (int i = 0; i != 3; i++)
            {
                if (matrixOfGame[i, 0] == matrixOfGame[i, 1] && matrixOfGame[i , 1] == matrixOfGame[i, 2] && matrixOfGame[i, 1] != "Y")
                {
                    return true;
                }
            }
            for (int j = 0; j != 3; j++)
            {
                if (matrixOfGame[0, j] == matrixOfGame[1, j] && matrixOfGame[1, j] == matrixOfGame[2, j] && matrixOfGame[2, j] != "Y")
                {
                    return true;
                }
            }
            if (matrixOfGame[0, 0] == matrixOfGame[1, 1] && matrixOfGame[1, 1] == matrixOfGame[2, 2] && matrixOfGame[2, 2] != "Y")
            {
                return true;
            }
            if (matrixOfGame[0, 2] == matrixOfGame[1, 1] && matrixOfGame[1, 1] == matrixOfGame[2, 0] && matrixOfGame[2, 0] != "Y")
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
            for (int i = 0; i != 3; i++)
            {
                for (int j = 0; j != 3; j++)
                {
                    matrixOfGame[i, j] = "Y";
                }
            }
            testOnNextDownKey = false;
            numberOfEnterKeys = 0;
        }
    }
}
