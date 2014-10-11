using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    /// <summary>
    /// Class for reading data from input text file.
    /// </summary>
    public class ReadOut
    {
        public GraphOfNetwork Graph { get; private set; }
        public bool[] ArrayOfRobots { get; private set; }
        private int NumberOfRobots { get; set; }
        private StreamReader Text { get; set; }

        /// <summary>
        /// Constructor for class.
        /// </summary>C:\Users\Дмитрий\Desktop\HomeWork\Robots\Robots\ReadOut.cs
        /// <param name="nameOfFile"></param>
        public ReadOut(string nameOfFile)
        {
            try
            {
                Text = new StreamReader(nameOfFile);
            }
            catch (FileNotFoundException e)
            {
                throw new NotExistFileException();
            }
            ReadingTextFile();
        }

        /// <summary>
        /// Read input data from text file.
        /// </summary>
        private void ReadingTextFile()
        {
            int NumberOfVertex = GetNumberFromLine();
            NumberOfRobots = GetNumberFromLine();
            ArrayOfRobots = new bool[NumberOfVertex];
            CreateArrayOfRobots();
            Graph = new GraphOfNetwork(NumberOfVertex);
            CreateGraph();
        }

        /// <summary>
        /// Get number of robots from file.
        /// </summary>
        /// <returns></returns>
        private int GetNumberFromLine()
        {
            string line = Text.ReadLine();
            int result = 0;
            try
            {
                result = Convert.ToInt32(line);
            }
            catch (FormatException e)
            {
                throw new IncorrectInputDataException();
            }
            if (result < 0)
            {
                throw new IncorrectInputDataException();
            }
            return result;
        }

        /// <summary>
        /// Create matrix of robot's network.
        /// </summary>
        private void CreateGraph()
        {
            for (int i = 0; Text.EndOfStream != true; i++)
            {
                string line = Text.ReadLine();
                if (line == "")
                {
                    break;
                }
                string[] parsedLine = line.Split(' ');
                if (parsedLine.Count() == 0)
                {
                    throw new IncorrectInputDataException();
                }
                if (String.Compare(parsedLine[0], "9") == 1 || String.Compare(parsedLine[0], "0") == -1)
                {
                    throw new IncorrectInputDataException();
                }
                if (String.Compare(parsedLine[1], "9") == 1 || String.Compare(parsedLine[1], "0") == -1)
                {
                    throw new IncorrectInputDataException();
                }
                Graph.CreateEdge(System.Convert.ToInt32(parsedLine[0]) - 1, System.Convert.ToInt32(parsedLine[1]) - 1);
            }
        }

        /// <summary>
        /// Create array of robot's network.
        /// </summary>
        private void CreateArrayOfRobots()
        {
            for (int i = 0; i < NumberOfRobots; i++)
            {
                string line = Text.ReadLine();
                string[] parsedLine = line.Split(' ');
                if (parsedLine[0] != "R")
                {
                    throw new IncorrectInputDataException();
                }
                ArrayOfRobots[System.Convert.ToInt32(parsedLine[1]) - 1] = true;
            }
        }
    }
}
