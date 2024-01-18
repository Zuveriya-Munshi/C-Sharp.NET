class input{
public static void Main(string[] args){
	Console.Write("Enter statement : ");
	string str = int.Parse(Console.ReadLine());
	Console.Write("Enter word : ");
	string ch =string.Parse(Console.ReadLine());
	Console.Write("Boolean : ");
	boolean bool = r.nextBoolean();	
	
	Console.Write("Enter integer number : ");
	int num = r.nextInt();
	Console.Write("Enter float number : ");
	float num1 = r.nextFloat();
	Console.Write("Enter double number : ");
	double num2 = r.nextDouble();
	Console.Write("Enter long number : ");
	long num3 = r.nextLong();
	Console.Write("Enter text : ");
	Console.Writeln(r.hasNext("bvm"));
	
	
	Console.Writeln("string : " + str);
	Console.Writeln("Word : "  + ch);
	Console.Writeln("Boolean : " + bool);
	Console.Writeln("Integer : " + num);
	Console.Writeln("Float : " +num1);
	Console.Writeln("Double : " +num2);
	Console.Writeln("Long : " +num3);
	
	
 }
}