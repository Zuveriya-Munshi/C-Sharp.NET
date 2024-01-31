using System;
using System.IO;
class Stud{
 public static void Main(string[] args){
	FileStream f1 = File.Create("E:\\6th Semester\\donNET\\Lab\\File Progs\\stud.txt");
		f1.Close();
	try{
	  StreamWriter f = new StreamWriter("E:\\6th Semester\\donNET\\Lab\\File Progs\\stud.txt");
	  
	  for(int i=0;i<2;i++){
	  Console.WriteLine("Enter Sid , Name , Number and CPI : ");
 	  String sid = Console.ReadLine();
	  String name = Console.ReadLine();
	  int number = Convert.ToInt32(Console.ReadLine());
	  int cpi = Convert.ToInt32(Console.ReadLine());
	  f.Write(sid);
	  f.Write(name);
	  f.Write(number);
	  f.Write(cpi);
	}
	f.Close();
	}

	catch(IOException e){
	Console.WriteLine("Exception : " + e);
	}
	
 }
}