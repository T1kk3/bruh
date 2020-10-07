using System;
using System.ComponentModel;

namespace pr_01_04_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Int16 i16 = 1;
            Int32 i32 = 1;
            double db = 1;
            //i16 = i32; - неявное преобразование запрещено
            i16 = (Int16)i32;
            //i16 = db;  - неявное преобразование запрещено
            i16 = (Int16)db;
            i32 = i16;
            //i32 = db;  - неявное преобразование запрещено
            i32 = (Int32)db;
            db = i16;
            db = i32;
        }
    }
}