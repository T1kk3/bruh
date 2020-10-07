using System;
using System.IO;

namespace pr_02_01_01
{
    class Program
    {
        static void ShowDirectory(DirectoryInfo dir)
        {
            foreach (FileInfo file in dir.GetFiles())
            {
                Console.WriteLine("File: {0}", file.FullName);
            }

            foreach (DirectoryInfo subDir in dir.GetDirectories())
            {
                ShowDirectory(subDir);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a path to directory you want to be shown: ");
            string path = Console.ReadLine();
            try
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                ShowDirectory(dir);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error! Perhaps you've enter an invalid path?");
            }
        }
    }
}