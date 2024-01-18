//Date : 06/07/2023


using System;
class fibonacci
{
	public static void Main(string[] args)
	{
		int num;
		// Scanner s= new Scanner(System.in);
		num=int.Parse(Console.ReadLine());
		// int num=s.nextInt();
		int f0=0, f1=1, f2=0;
		Console.Write(f0 + ", " + f1);
		for(int i=0;i<num;i++)
		{
			f2 = f0+f1;
			Console.Write(", " + f2);
			f0=f1;
			f1=f2;
			
		}
	}
}
	