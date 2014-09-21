using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    /// <summary>
    /// Class for reading data from input text file.
    /// </summary>
    public class ReadOut
    {
        public GraphOfNetwork Graph { get; private set; }
        public Computer[] ArrayOfComputer { get; private set; }
        private int NumberOfComputers { get; set; }
        private StreamReader text { get; set; }

        /// <summary>
        /// Constructor for class.
        /// </summary>
        /// <param name="nameOfFile"></param>
        public ReadOut(string nameOfFile)
        {
            try
            {
                text = new StreamReader(nameOfFile);
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
            NumberOfComputers = GetNumberOfComputers();
            ArrayOfComputer = new Computer[NumberOfComputers];
            CreateArrayOfComputers();
            Graph = new GraphOfNetwork(NumberOfComputers);
            CreateGraph();
        }

        /// <summary>
        /// Get number of computer from file.
        /// </summary>
        /// <returns></returns>
        private int GetNumberOfComputers()
        {
            string line = text.ReadLine();
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
        /// Create matrix of network.
        /// </summary>
        private void CreateGraph()
        {
            for (int i = 0; i < NumberOfComputers; i++)
            {
                string line = text.ReadLine();
                string[] parsedLine = line.Split(' ');
                if (String.Compare(parsedLine[0], "9") == 1 || String.Compare(parsedLine[0], "0") == -1)
                {
                    throw new IncorrectInputDataException();
                }
                int ComputerNumber = Convert.ToInt32(parsedLine[0]) - 1;
                if (ComputerNumber >= NumberOfComputers || ComputerNumber < 0)
                {
                    throw new IncorrectInputDataException();
                }
                for (int j = 1; j < parsedLine.Count(); j++)
                {
                    int temp = Convert.ToInt32(parsedLine[j]) - 1;
                    if (temp >= NumberOfComputers || temp < 0)
                    {
                        throw new IncorrectInputDataException();
                    }
                    Graph.CreateEdge(ComputerNumber, temp);
                }
            }
        }

        /// <summary>
        /// Create array of network's computers.
        /// </summary>
        private void CreateArrayOfComputers()
        {
            for (int i = 0; i < NumberOfComputers; i++)
            {
                string line = text.ReadLine();
                string[] parsedLine = line.Split(' ');
                if (parsedLine.Count() > 3)
                {
                    throw new IncorrectInputDataException();
                }
                OS installedOs = default(OS);
                switch (parsedLine[0])
                {
                    case "Windows":
                        installedOs = new Windows();
                        break;
                    case "MacOS":
                        installedOs = new MacOS();
                        break;
                    case "Linux":
                        installedOs = new Linux();
                        break;
                    default:
                        throw new IncorrectInputDataException();
                }
                ArrayOfComputer[i] = new Computer(installedOs, parsedLine[1] == "1");
            }
        }
    }
}
