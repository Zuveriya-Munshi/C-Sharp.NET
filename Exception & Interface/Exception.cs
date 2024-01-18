using System;

public class Exp
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter n1 : ");
		int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter n2 : ");

        int n2 = Convert.ToInt32(Console.ReadLine());
		double n3;

        try
		{
			 n3 = n1 / n2;
            Console.WriteLine("Answer : " + n1 + " / " + n2 + " = " + n3);


        }
        catch (DivideByZeroException e)
		{
			Console.WriteLine("Exception : " + e);
		}

	}
}