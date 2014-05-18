using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR
{
    public interface IPlayer
    {
        string Symbol { get; set; }

        void MakeStep(int x, int y, string[,] matrixOfGame, int sizeOfMatrix);
    }
}
