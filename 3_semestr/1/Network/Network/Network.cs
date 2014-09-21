using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    /// <summary>
    /// Class of network.
    /// </summary>
    public class Network
    {
        private GraphOfNetwork Graph { get; set; }
        private Computer[] ArrayOfComputers { get; set; }
        private Random randomizer { get; set; }

        /// <summary>
        /// Constructor of class, if entered number for randomizer.
        /// </summary>
        /// <param name="inputData"></param>
        /// <param name="NumberForRandom"></param>
        public Network(ReadOut inputData, int NumberForRandom)
        {
            ArrayOfComputers = inputData.ArrayOfComputer;
            Graph = inputData.Graph;
            randomizer = new Random(NumberForRandom);
        }

        /// <summary>
        /// Constructor for class.
        /// </summary>
        /// <param name="inputData"></param>
        public Network(ReadOut inputData)
        {
            ArrayOfComputers = inputData.ArrayOfComputer;
            Graph = inputData.Graph;
            randomizer = new Random();
        }

        /// <summary>
        /// Class, traverses the network. Checks the possibility of infecting computers in communication with a source of infection.
        /// </summary>
        public void OneTact()
        {
            for (int i = 0; i < Graph.NumberOfVertex; i++)
            {
                for (int j = 0; j < Graph.NumberOfVertex; j++)
                {
                    if (Graph.CheckEdge(i, j) && ArrayOfComputers[i].Infected)
                    {
                        ArrayOfComputers[j].CheckInfection(randomizer);
                    }
                }
            }
        }

        /// <summary>
        /// Return inforation about state of the network.
        /// </summary>
        /// <returns></returns>
        public string GetInformation()
        {
            string result = "";
            for (int i = 0; i < Graph.NumberOfVertex; i++)
            {
                result += Convert.ToString(i) + ' ' + ArrayOfComputers[i].OS.Name + ' ' + ArrayOfComputers[i].Infected + '\n';
            }
            return result;
        }
    }
}
