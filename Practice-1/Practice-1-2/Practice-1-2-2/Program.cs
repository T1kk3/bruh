using System;

namespace pr_01_02_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Microsoft .NET Framework 2 Application Development Foundation";
            string[] sa = s.Split(" ");
            Array.Sort(sa);
            s = String.Join(" ", sa);
            Console.WriteLine(s);
        }
    }
}