using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR
{
    public class Game
    {
        /// <summary>
        /// Place of game.
        /// </summary>
        GamePlace GamePlace { get; set; }

        /// <summary>
        /// Make step.
        /// </summary>
        /// <param name="nextPlayer"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public IPlayer MakeStep(byte nextPlayer, int x, int y)
        {
            if (nextPlayer == 1)
            {
                IPlayer temp = GamePlace.MakeFirstStep(x, y);
                matrixOfGame = GamePlace.MatrixOfGame;
                return temp;
            }
            else
            {
                IPlayer temp = GamePlace.MakeSecondStep(x, y);
                matrixOfGame = GamePlace.MatrixOfGame;
                return temp;
            } 
        }

        /// <summary>
        /// Full matrix.
        /// </summary>
        /// <returns></returns>
        public bool IsFull()
        {
            return GamePlace.NumberOfFull == GamePlace.SizeOfMatrix * GamePlace.SizeOfMatrix;
        }

        /// <summary>
        /// Clear matrix.
        /// </summary>
        public void Clear()
        {
            GamePlace.Clear();
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="gamePlace"></param>
        public Game(GamePlace gamePlace)
        {
            GamePlace = gamePlace;
            matrixOfGame = gamePlace.MatrixOfGame;
        }

        public string[,] matrixOfGame;
    }
}
