using System;
using System.IO;

namespace pr_02_01_02
{
    class Program
    {
        static void Main(string[] args)
        {
            FileSystemWatcher watcher = new FileSystemWatcher("/var/log");
            //watcher.Filter = "*.ini";
            watcher.IncludeSubdirectories = true;
            watcher.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.Size;
            watcher.Changed += new FileSystemEventHandler(watcher_Changed);
            watcher.EnableRaisingEvents = true;
            Console.Read();
        }
        static void watcher_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Changed: {0}", e.FullPath);
        }
    }
}