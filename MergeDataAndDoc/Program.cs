using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeDataAndDoc
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFileName = "";
            string outputFileName = "";

            if (args.Length == 2)
            {
                {
                    inputFileName = args[0];
                    outputFileName = args[1];
                    Console.WriteLine("The files has been loaded");
                }

                using (StreamReader inputFile = new StreamReader(inputFileName))
                using (StreamWriter outputFile = new StreamWriter(outputFileName))
                {
                    string line; //test
                    while ((line = inputFile.ReadLine()) != null)
                    {
                        string outputLine = "***" + line;
                        Console.WriteLine("Write line: " + outputLine);
                        outputFile.WriteLine(outputLine);
                    }
                }
            }
            else
            {
                Console.WriteLine("The files loading is fail");
            }

            Console.Read();
        }
    }
}
