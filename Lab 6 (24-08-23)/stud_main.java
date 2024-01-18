using System;
class Student{
int idno;
int rank;
public Student(){
idno = 0;
rank = 0;
}
public Student(int id, int r){
	idno = id;
	rank=r;
  }
public int getRank(){
	return rank;
  }
public int getId(){
return idno;}
}
class stud_main{
public static void Main(string[] arg){
int i;
Console.WriteLine("How many Students : ");
int n = Convert.ToInt32(Console.ReadLine());
Student[] s = new Student[n];
for(i=0;i<n;i++){
  	Console.Write("Enter ID : ");
	int id = Convert.ToInt32(Console.ReadLine());
	Console.Write("Enter Rank : ");
	int rank = Convert.ToInt32(Console.ReadLine());
	
	s[i] = new Student(id,rank);
  }
  Console.WriteLine("Enter r1 : ");
  int r1 = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Enter r2 : ");
  int r2 = Convert.ToInt32(Console.ReadLine());
try {
		if(r1<0 || r2<0) throw new Exception();	
	for(i=0;i<n;i++){
 	if(s[i].getRank()>=r1 && s[i].getRank()<=r2){
	  Console.WriteLine("Student Id between " + r1 + " & " + r2 + " : " + s[i].getId());
	}
	}
}
	catch(Exception e){
	Console.WriteLine("Negative value for r1 & r2 not allowed " + e);
	} 

  
 }
}