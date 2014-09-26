using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadOut input = new ReadOut("..\\..\\inform.txt");
            Network network = new Network(input, 38);
            while (true)
            {
                var key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.Enter:
                        Console.Clear();
                        Console.WriteLine(network.GetInformation());
                        network.OneTact();
                        break;
                }
            } 
        }
    }
}
