using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR
{
    public class User : IPlayer
    {
        /// <summary>
        /// Symbol of player.
        /// </summary>
        public string Symbol { get; set; }

        /// <summary>
        /// Make step.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="matrixOfGame"></param>
        /// <param name="sizeOfMatrix"></param>
        public void MakeStep(int x, int y, string[,] matrixOfGame, int sizeOfMatrix)
        {
            matrixOfGame[x, y] = Symbol;
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="symbol"></param>
        public User(string symbol)
        {
            Symbol = symbol;
        }
    }
}
