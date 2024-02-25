using System;
using System.Threading;
class Child
{
	private string msg;
	private int th_id;
	private Thread thread;
	public Child(string name, int id, string m)
	{
		msg = m;
		th_id = id;
		thread = new Thread(Run);
		thread.Name = name;
		thread.Start();
	}
	public void Run()
	{
		try
		{
			for (int i = 0; i < 4; i++)
			{
				Console.WriteLine(" Id : " + th_id + " Message : " + msg + " Iteration : " + i);
				Thread.Sleep(100);
			}
		}
		catch (ThreadInterruptedException)
		{
			Console.WriteLine("Interrupted Exception");
		}
	}
	public void Join()
	{
		thread.Join();
	}
}
class MainThread
{
	public static void Main(string[] args)
	{
		Child c1 = new Child("Child 1", 1, "Running from Child 1");
		Child c2 = new Child("Child 2", 2, "Running from Child 2");
		Child c3 = new Child("Child 3", 3, "Running from Child 3");
		try
		{
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine("Main Thread : " + i);
				Thread.Sleep(20);
			}
		}
		catch (ThreadInterruptedException)
		{
			Console.WriteLine("Interrupted Exception from main");
		}
		try
		{
			c1.Join();
			c2.Join();
			c3.Join();
		}
		catch (ThreadInterruptedException)
		{
			Console.WriteLine("Interrupted Exception from main");
		}
	}
}