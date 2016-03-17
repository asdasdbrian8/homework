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
            string inputFileName1 = "";
            string inputFileName2 = "";
            string outputFileName = "未命名.txt";
            string[] data;
            string[] template;
            string[] temp = new string[3];

            if (args.Length == 3)
            {
                inputFileName1 = args[0];
                inputFileName2 = args[1];
                outputFileName = args[2];

                Console.WriteLine("The files has been loaded");

                try
                {
                    using (StreamReader inputFile1 = new StreamReader(inputFileName1, System.Text.UTF8Encoding.Default))
                    using (StreamReader inputFile2 = new StreamReader(inputFileName2, System.Text.UTF8Encoding.Default))
                    //stringreader:讀取記事本時會發生亂碼(cmd預設unicode 但中文是utf8)
                    using (StreamWriter outputFile = new StreamWriter(outputFileName))
                    {     
                        string dataline;
                        string templine = inputFile2.ReadLine();

                        while ((dataline = inputFile1.ReadLine()) != null)
                        {
                            data = dataline.Split('\t');

                            temp[0] = data[0];
                            temp[1] = data[1];
                            temp[2] = data[2];
                            //
                            templine.Replace(@"$1", temp[0]);
                            templine.Replace(@"$2", temp[1]);
                            templine.Replace(@"$3", temp[2]);

                            Console.WriteLine(templine);


                            outputFile.WriteLine(templine);
                        }
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Cannot find file or wrong file type");
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
