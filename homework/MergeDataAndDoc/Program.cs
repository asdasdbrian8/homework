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
            if (args.Length == 3)
            {
                string inputFileName1 = "";
                string inputFileName2 = "";
                string outputFileName = "未命名.txt";
                inputFileName1 = args[0];
                inputFileName2 = args[1];
                outputFileName = args[2];
                using (StreamReader inputFile1 = new StreamReader(inputFileName1, System.Text.UTF8Encoding.Default))
                using (StreamReader inputFile2 = new StreamReader(inputFileName2, System.Text.UTF8Encoding.Default))
                //stringreader:讀取記事本時會發生亂碼(cmd預設unicode 但中文是utf8)
                using (StreamWriter outputFile = new StreamWriter(outputFileName))
                    come(inputFileName1, inputFileName2, outputFileName);
            }
            else
            {
                Console.WriteLine("The files loading is fail");
            }
        }
        public static void come(string inputFileName1, string inputFileName2, string outputFileName)
        {
            string[] temp = new string[3];

            Console.WriteLine("The files has been loaded");

            string templine = inputFileName2.ReadLine();

            while ((dataline = inputFileName1.ReadLine()) != null)
            {
                data = dataline.Split('\t');
                string outline = templine.Replace("name", data[0]).Replace("id", data[1]).Replace("time", data[2]);
                outputFile.WriteLine(outline);
            }
        }
    }
}