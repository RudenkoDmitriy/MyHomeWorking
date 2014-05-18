using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR
{
    public class Computer : IPlayer
    {
        /// <summary>
        /// Symbol
        /// </summary>
        public string Symbol { get; set; }

        /// <summary>
        /// Make step.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="matrixOfGame"></param>
        /// <param name="sizeOfMatrix"></param>
        public void MakeStep(int x,int y, string[,] matrixOfGame, int sizeOfMatrix)
        {
            for (int i = 0; i < sizeOfMatrix; i++)
            {
                for (int j = 0; j < sizeOfMatrix; j++)
                {
                    if (matrixOfGame[i, j] == "")
                    {
                        matrixOfGame[i, j] = Symbol;
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="symbol"></param>
        public Computer(string symbol)
        {
            Symbol = symbol;
        }
    }
}
