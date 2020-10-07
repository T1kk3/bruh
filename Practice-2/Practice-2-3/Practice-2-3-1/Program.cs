using System;
using System.IO;
using System.IO.Compression;

namespace pr_02_03_01
{
    class Program
    {
        static void CompressFile(string inFilename, string outFilename)
        {
            FileStream sourceFile = File.OpenRead(inFilename);
            FileStream destFile = File.OpenWrite(outFilename);
            GZipStream compStream = new GZipStream(destFile, CompressionMode.Compress);
            int theByte = sourceFile.ReadByte();
            while (theByte != -1)
            {
                compStream.WriteByte((byte)theByte);
                theByte = sourceFile.ReadByte();
            }

            compStream.Close();
            sourceFile.Close();
            destFile.Close();
        }

        static void Main(string[] args)
        {
            string path_in = "/home/matt/test.txt";
            string path_out = path_in + ".gz";
            CompressFile(path_in, path_out);
        }
    }
}