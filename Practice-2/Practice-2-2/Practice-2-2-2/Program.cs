using System;
using System.IO;

namespace pr_02_02_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Environment.CurrentDirectory + "/newfile.txt";
            StreamWriter writer = File.CreateText(path);
            writer.WriteLine("This is my new file");
            writer.WriteLine("Do you like its format?");
            writer.Close();
            StreamReader reader = File.OpenText(path);
            string contents = reader.ReadToEnd();
            reader.Close();
            Console.WriteLine(contents);
        }
    }
}