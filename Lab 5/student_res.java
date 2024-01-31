using System;
class student{
	protected string name;
	protected int id;
	public student(){
	name= null;
	id=0;
	}
	public student(string name,int id){
	this.name = name;
	this.id=id;
	}
	/*int getId(){
		return id;
	}
	string getName(){
		return name;
	}*/

}
class result : student{
	int rank;
 	float spi;
	result() : base(){ 
	
	rank=0;
	spi=0;
	}
	public result(string name,int id,int rank,float spi) : base(name,id){
		
		this.rank=rank;
		this.spi=spi;
	}
	public int getRank(){
		return rank;
	}
	public float getSpi(){
		return spi;
	}
	
	public void display(){
		Console.WriteLine("Name : " +name+ " Id : "+id+ " Rank : "+rank+ " SPI : "+spi);
	}
}
class student_res{
public static void Main(string[] args){
	
	float max= 0;
	 
	Console.WriteLine("How many Students : ");
	int n = Convert.ToInt32(Console.ReadLine());
	result[] res = new result[n];
	for(int i=0;i<n;i++){
	Console.WriteLine("Enter Details of Student "+(i+1));
	Console.Write("Enter Name : ");
	string name = Convert.ToString(Console.ReadLine());
	Console.Write("Enter ID : ");
	int id = Convert.ToInt32(Console.ReadLine());
	Console.Write("Enter Rank : ");
	int rank = Convert.ToInt32(Console.ReadLine());
	Console.Write("Enter SPI : ");
	float spi = Convert.ToSingle(Console.ReadLine());
	res[i] = new result(name,id,rank,spi);
	
	
	res[i].display();
     }
	for(int i=0;i<n;i++){
	if( res[i].getSpi()>max)
	  {
		max = res[i].getSpi();
		Console.WriteLine("Student with Highest SPI : ");
		res[i].display();
	  }
	  if(res[i].getRank()<10)
	  {
		Console.WriteLine("Student with Rank<10 : ");
		res[i].display();
	  }
	}
  }
}