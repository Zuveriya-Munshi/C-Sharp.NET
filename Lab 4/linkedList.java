using System;
class Node
{
  Node next;
  int data;
  public Node()
  {
	next=null;
	data=0;
  }
  public Node(int data)
  {	
	this.data = data;
	next = null;
  }
  public void append(Node newNode)
  {
	Node t_ref = this;
	while(t_ref.next != null)
	{
		t_ref = t_ref.next;
	}
	Console.Write(newNode.data + " is Appended ");
	t_ref.next = newNode;
	Console.WriteLine();
  }
  public void delete()
  {
	Node t_ref = this;
	while(t_ref.next.next != null)
	{
		t_ref = t_ref.next;
	}
 
Console.WriteLine();
	Console.WriteLine(t_ref.next.data + " is Deleted ");
	t_ref.next=null;
  }
  public void traverse()
  {
	Node t_ref = this;
	Console.Write("Linked List : " );
	while(t_ref != null)
	{
		Console.Write(t_ref.data + " ");
		t_ref = t_ref.next;
		
	}

  }
public void search(int key)
{
Node t_ref = this;
  
	while(t_ref != null)
	{
		if(t_ref.data == key)
		Console.Write("\n" + t_ref.data + " found  ");
		
	t_ref = t_ref.next;	
	}
}

}
class linkedList
{
	public static void Main(string[] args)
	{
		Node first = new Node(5);
		Node ref1 = new Node(15);
		Node ref2 = new Node(25);
		first.append(ref1);
		first.append(ref2);
		first.traverse();
		
		first.delete();
		first.traverse();
		first.search(15);
	}
}
