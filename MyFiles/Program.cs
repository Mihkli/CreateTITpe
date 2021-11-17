using System;
using System.IO;

namespace MyFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\opilane\Samples\TITpe21\myFiles.txt";
            string[] datafromfile = File.ReadAllLines(filepath);
            string myfiles = @"C:\Users\opilane\Samples\TITpe21";

            for (int i = 0; i < datafromfile.Length; i++)
            {
                datafromfile[i] = datafromfile[i].Replace('3', 'e');
                datafromfile[i] = datafromfile[i].Replace('1', 'i');
                datafromfile[i] = datafromfile[i].Replace('0', 'o');
                datafromfile[i] = datafromfile[i].Replace('4', 'a');

            }
            
            foreach (string line in datafromfile)
            {
                Console.WriteLine(line);
                File.Create($@"{myfiles}\{line + ".txt"}");
            }

            
        }
    }
}
