using System;
using System.IO;
namespace labwork.java_lab5
{
    internal class FileIODemo
    {
        public static void Main()
        {
            StreamReader sr = new StreamReader("E:\\6th Semester\\donNET\\Lab\\File Progs\\test.txt");
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
            StreamWriter sw = new StreamWriter("E:\\6th Semester\\donNET\\Lab\\File Progs\\test.txt");
            sw.WriteLine("how are you?");
            sw.Flush();
            sw.Close();
        }
    }
}