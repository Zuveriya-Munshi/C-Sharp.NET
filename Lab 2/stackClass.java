using System;
public class stackClass
{
		int top,capacity;
		int[] arr;
		public stackClass(int size)
		{	
			arr = new int[size];
			capacity = size; 
			top=-1;
		}
	
		public void push(int data)
		{
			if(isFull())
			{
				Console.WriteLine("Stack Overflow"); 
				Environment.Exit(1);
			}
			Console.WriteLine(data + " is Pushed ");
			arr[++top]=data;
		}
		public int pop()
		{
			if(isEmpty())
			{
				Console.WriteLine("Stack Underflow"); 
				Environment.Exit(1);
			}
		
			return arr[top--];
		}
		public Boolean isFull()
 		{
			return top == capacity-1;
		}
		public Boolean isEmpty()
 		{
			return top == -1;
		}
		
 		public void print()
		{
			for(int i=0;i<=top;i++)
			  {
				Console.Write(arr[i] + " ");
	 		  }Console.WriteLine();
		}
		
	
	public static void Main(string[] args)
	{
	  stackClass s = new stackClass(10);
	  s.push(5);
	  s.push(3);
	  s.push(13);
          Console.Write("Stack : ");
          s.print();
          s.pop();
Console.Write("Stack After Popping out : ");
	    s.print();
			
	}
	
}