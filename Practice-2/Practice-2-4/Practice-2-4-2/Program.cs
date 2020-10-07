using System;
using System.IO;
using System.IO.IsolatedStorage;

namespace pr_02_04_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // При использовании GetMachineStoreForAssembly возникают проблемы с доступом,
            // так что здесь хранилище будет создаваться в директории пользователя, а не системы

            IsolatedStorageFile userStore = IsolatedStorageFile.GetUserStoreForAssembly();
            IsolatedStorageFileStream userStream = new IsolatedStorageFileStream("UserSettings.set", FileMode.Create, userStore);
            StreamWriter userWriter = new StreamWriter(userStream);
            userWriter.WriteLine("User Prefs");
            userWriter.Close();

            string[] files = userStore.GetFileNames("UserSettings.set");
            if (files.Length == 0)
            {
                Console.WriteLine("File not found");
            }
            else
            {
                userStream = new IsolatedStorageFileStream("UserSettings.set", FileMode.Open, userStore);
                StreamReader userReader = new StreamReader(userStream);
                string contents = userReader.ReadToEnd();
                Console.WriteLine(contents);
            }
        }
    }
}