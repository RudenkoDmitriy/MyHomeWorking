using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR
{
    public class User : IPlayer
    {
        public string Symbol { get; set; }

        public void MakeStep(int x, int y, string[,] matrixOfGame, int sizeOfMatrix)
        {
            matrixOfGame[x, y] = Symbol;
        }

        public User(string symbol)
        {
            Symbol = symbol;
        }
    }
}
