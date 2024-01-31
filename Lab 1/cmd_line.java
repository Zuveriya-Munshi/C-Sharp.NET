//Date : 06/07/2023
using System;

class cmd_line
{
	public static void Main(String[] args)
	{
		Console.WriteLine("Number of Arguments : " + args.Length);
		for(int i=0;i<args.Length;i++)
		{
			Console.WriteLine(args[i] + " ");
		}
	}
}