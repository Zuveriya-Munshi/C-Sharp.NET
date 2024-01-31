using System;
using System.IO;
class str_byte{
	public static void Main(string[] args){
   try{
	StreamReader fin = new StreamReader("E:\\6th Semester\\donNET\\Lab\\File Progs\\file.txt");
	FileStream f1 = File.Create("E:\\6th Semester\\donNET\\Lab\\File Progs\\file_byte.txt");
			//int i;
			f1.Close();
            if (File.Exists("E:\\6th Semester\\donNET\\Lab\\File Progs\\file_byte.txt"))
            {
                Console.WriteLine("File was created");
            }
            else
                Console.WriteLine("Already Exists");
            f1.Close();
            StreamWriter fout = new StreamWriter("E:\\6th Semester\\donNET\\Lab\\File Progs\\file_byte.txt");
	string path= "E:\\6th Semester\\donNET\\Lab\\File Progs\\file.txt";
        //string spath = "E:\\6th Semester\\donNET\\Lab\\File Progs\\file.txt";

            byte[] text = File.ReadAllBytes(path);
	foreach(byte b in text)
			{
				fout.Write(b);
				Console.WriteLine(b);
			}
	fin.Close();
	fout.Close();	
   }
   catch(IOException e){
	Console.WriteLine("Exception : " + e);
   }
 }
}