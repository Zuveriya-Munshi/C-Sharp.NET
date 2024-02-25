using System;
using System.IO;
namespace File_Progs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("E:\\6th Semester\\donNET\\Lab\\File Progs\\Demo.txt");
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
            StreamWriter sw = new StreamWriter("E:\\6th Semester\\donNET\\Lab\\File Progs\\Demo.txt");
            sw.WriteLine("Hello World is written to demo file");
            sw.Flush();

        }
    }
}


