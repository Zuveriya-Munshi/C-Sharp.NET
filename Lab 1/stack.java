using System;
class stackCmd
{
  int top;
  int[] arr;
  int cap;
  public stackCmd(int cap)
  {
	this.cap = cap;
	top=-1;
	arr = new int[cap];
  }
  public void push(int data)
  {
	if(isFull())
	{
	  Console.WriteLine("Stack Overflow");	
	  Environment.Exit(0);
	}
        arr[++top] = data;
	Console.WriteLine(data + " is pushed ");
  }
  public int pop()
  {
	if(isEmpty())
	{
	  Console.WriteLine("Stack Underflow");	
	  return -1;
	}
	return arr[top--];
  }
  public bool isFull()
  {
	return top == cap-1;
  }
  public bool isEmpty()
  {
	return top == -1;
  }
  public void print()
  {
	Console.Write("Stack : ");
	for(int i=0;i<=top;i++)
	{
		Console.Write(arr[i] + " ");
		
	}Console.WriteLine();
  }
}
class stack
{
  public static void Main(string[] args)
  {
	int cap = 10;
	stackCmd s = new stackCmd(cap);
	try{ 
		for(int i=0;i<args.Length;i++)
		{ 
		  String op = args[i];
		  if(op=="push")
		  { 
			i++;
			int val = int.Parse(args[i]);
			s.push(val);
		  }
		  else if(op == "pop")
		  {
 			int poppedVal = s.pop();
			if(poppedVal != -1)
			Console.WriteLine(poppedVal + " is Popped");
		  }
		  if(op=="print")
		  {
                    s.print();
		  }
		}
	}
	catch(FormatException)
	{
		Console.WriteLine("Invalid Number format ");
	}
  }
}
