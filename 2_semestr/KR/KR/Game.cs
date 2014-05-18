using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR
{
    public class Game
    {
        GamePlace GamePlace { get; set; }

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

        public bool IsFull()
        {
            return GamePlace.NumberOfFull == GamePlace.SizeOfMatrix * GamePlace.SizeOfMatrix;
        }

        public void Clear()
        {
            GamePlace.Clear();
        }

        public Game(GamePlace gamePlace)
        {
            GamePlace = gamePlace;
            matrixOfGame = gamePlace.MatrixOfGame;
        }

        public string[,] matrixOfGame;
    }
}
