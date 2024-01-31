using System;
class rangeExp
{
 public static void Main(string[] args)
 {
	Console.WriteLine("Enter number : ");
	int n = Convert.ToInt32(Console.ReadLine());
	int sum=0;

	while(n!=0){
 
	try{
		if(n<-1000 || n>1000) throw new Exception();
		sum+=n;
		//if(no==0) break;
	}
	catch(Exception e){
		Console.WriteLine("Out of range(-1000 to 1000) :" + e);
	  }
	Console.WriteLine("Enter next number (Press 0 to Exit) : ");
	n = Convert.ToInt32(Console.ReadLine());
	}
	Console.WriteLine("Sum of positive numbers : " + sum);
 }
}