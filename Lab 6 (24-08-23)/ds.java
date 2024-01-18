using System;

class data_structure
{
  
   public int n;
   public int []info ;
  public int get_data(){
return info[n];}
  public void put_data(){
}
}
class my_stack : data_structure{
int top;

    public my_stack()
    {
        top=-1;

    }
    public my_stack(int n)
    {
       this.n = n;
	top = -1;
	info=new int[n];
        
    }
    public new int get_data()
    {
       if(top<0)
       {
           Console.WriteLine("Stack is empty");
           return 0;
       }
       else {  Console.WriteLine(info[top] + " is deleted from stack ");
		 return info[top--];}
    }
    public void put_data(int data)
    {
	
      if(top==n-1)
      {
           Console.WriteLine("Stack is full");
           return;
      }
info[++top]=data; Console.WriteLine(data + " is inserted in stack ");
 
    }

}
class my_queue : data_structure{
int front,rear;

public my_queue(int n){
this.n = n;
	front=0;
rear = -1;
	info=new int[n];
        
}
    public new int get_data()
    {
         if(front<0)
       {
           Console.WriteLine("Queue is empty");
           return 0;
       }
       else { Console.WriteLine(info[front] + " is deleted from queue "); return info[front++];}
    }
   public void put_data(int data)
    {
        if(rear>=n)
      {
           Console.WriteLine("Queue is full");
           return;
      }
      else info[++rear]=data; Console.WriteLine(data + " is inserted in queue");

    }
}
class ds{
public static void Main(string[] args){
 my_stack s = new my_stack(10);
 my_queue q = new my_queue(10);
 s.put_data(1);
 s.put_data(3);
 s.get_data();
q.put_data(11);
 q.put_data(12);
 q.get_data();
 
}
}