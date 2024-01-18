import java.io.*;
import java.util.*;
class stud{
 public static void main(String args[]){
	File f1 = new File("D:\\22CP321\\Lab 7 (14-09-23)\\stud.txt");
	try{
	  FileWriter f = new FileWriter("D:\\22CP321\\Lab 7 (14-09-23)\\stud.txt");
	  Scanner s = new Scanner(System.in);
	  
	  for(int i=0;i<2;i++){
	  System.out.println("Enter Sid , Name , Number and CPI : ");
 	  String sid = s.next();
	  String name = s.next();
	  int number = s.nextInt();
	  int cpi = s.nextInt();
	  f.write(sid);
	  f.write(name);
	  f.write(number);
	  f.write(cpi);
	}
	f.close();
	}

	catch(IOException e){
	System.out.println("Exception : " + e);
	}
	
 }
}