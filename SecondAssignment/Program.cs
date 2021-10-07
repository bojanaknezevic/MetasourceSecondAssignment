using System;
using System.Diagnostics;
using System.IO;

namespace SecondAssignment
{
    class Program
    {
        public static void MergeFiles(string path1, string path2, string outputFile)
        {
           File.WriteAllText(outputFile, File.ReadAllText(path1) + File.ReadAllText(path2));
        }
        static void Main(string[] args)
        {
            string pathFile1 = "files/USCities.txt";
            string pathFile2 = "files/CACities.txt";
            string outputFile = "files/outputFile.txt";

            MergeFiles(pathFile1, pathFile2, outputFile);

            var contents = File.ReadAllLines(outputFile);
            Array.Sort(contents);
            File.WriteAllLines(outputFile, contents);

            //I didn't know how to open the right file, besides to use the path this way. 
            //That's why I'm commenting out this part, so the solution can work with only merging 
            //two files in one alphabetically, without opening it. 

            /*
            var fileToOpen = "C:/Users/bojan/source/repos/SecondAssignment/SecondAssignment/bin/Debug/net5.0/files/outputFile.txt";
            var process = new Process();
            process.StartInfo = new ProcessStartInfo()
            {
                UseShellExecute = true,
                FileName = fileToOpen
            };

            process.Start();
            process.WaitForExit();
            */
        }
    }   
}
