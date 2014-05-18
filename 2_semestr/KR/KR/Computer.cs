using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR
{
    public class Computer : IPlayer
    {
        public string Symbol { get; set; }

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

        public Computer(string symbol)
        {
            Symbol = symbol;
        }
    }
}
