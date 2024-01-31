import java.io.*;
class str_byte{
	public static void main(String args[]){
   try{
	FileInputStream fin = new FileInputStream("D:\\22CP321\\Lab 7 (14-09-23)\\file3.txt");
	File f1 = new File("D:\\22CP321\\Lab 7 (14-09-23)\\file3_byte.txt");
	int i;
	if(f1.createNewFile()){
		System.out.println("File was created");
	}
	else
		System.out.println("Already Exists");
	FileOutputStream fout = new FileOutputStream("D:\\22CP321\\Lab 7 (14-09-23)\\file3_byte.txt");
	String s="";
	while((i = fin.read()) != -1){
		
		s+=i;
		
	}
	byte b[] = s.getBytes();
	fout.write(b);
	fin.close();
	fout.close();	
   }
   catch(IOException e){
	System.out.println("Exception : " + e);
   }
 }
}