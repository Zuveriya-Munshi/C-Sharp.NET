using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string file1Path = "E:\\6th Semester\\donNET\\Lab\\File Progs\\file1.txt";
        string file2Path = "E:\\6th Semester\\donNET\\Lab\\File Progs\\file2.txt";
        string outputFile = "E:\\6th Semester\\donNET\\Lab\\File Progs\\output.txt";

        try
        {
            string file1Content = File.ReadAllText(file1Path);
            string file2Content = File.ReadAllText(file2Path);

            using (StreamWriter writer = File.AppendText(outputFile))
            {
                writer.WriteLine(file1Content);
                writer.WriteLine(file2Content);
            }

            Console.WriteLine("Content from file1 and file2 has been appended to output.txt");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
