//Date : 06/07/2023
// import java.util.*;

// import java.io.Console;

using System;
class min_max
{
	public static void Main(string[] args)
	{
		// Scanner s = new Scanner(System.in);
		
		Console.Write("Enter value of a : " );
		int a=int.Parse(Console.ReadLine());
		Console.Write("Enter value of b : " );
		int b=int.Parse(Console.ReadLine());

		Console.Write("Enter value of c : " );
		int c=int.Parse(Console.ReadLine());

		if(a>b && a>c)
			Console.WriteLine(a + " is Maximum");

		else if (b>a && b>c)
			Console.WriteLine(b + " is Maximum");

		else
			Console.WriteLine(c + " is Maximum");

		if(a<b && a<c)
			Console.WriteLine(a + " is Minimum");

		else if (b<a && b<c)
			Console.WriteLine(b + " is Minimum");
		
		else
			Console.WriteLine(c + " is Minimum");
		
	}
}	
		