using System;
class input{
public static void Main(string []args){
	Console.Write("Enter statement : ");
	string str = Convert.ToString(Console.ReadLine());
	Console.Write("Enter word : ");
	char ch = Convert.ToChar(Console.ReadLine());
	Console.Write("Boolean : ");
	bool b = Convert.ToBoolean(Console.ReadLine());	
	
	Console.Write("Enter integer number : ");
	int num = Convert.ToInt32(Console.ReadLine());
	Console.Write("Enter float number : ");
	float num1 = Convert.ToSingle(Console.ReadLine());
	Console.Write("Enter double number : ");
	double num2 = Convert.ToDouble(Console.ReadLine());
	Console.Write("Enter long number : ");
	long num3 = Convert.ToInt64(Console.ReadLine());
	//Console.Write("Enter text : ");
	//Console.WriteLine(Convert.ToInt32(Console.ReadLine()));
	
	
	Console.WriteLine("string : " + str);
	Console.WriteLine("Word : "  + ch);
	Console.WriteLine("Boolean : " + b);
	Console.WriteLine("Integer : " + num);
	Console.WriteLine("Float : " +num1);
	Console.WriteLine("Double : " +num2);
	Console.WriteLine("Long : " +num3);
	
	
 }
}