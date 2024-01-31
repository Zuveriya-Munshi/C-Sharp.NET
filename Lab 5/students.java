using System;

class student {
    protected string name;
    protected int id;
    public student(){
        name = null;
        id = 0;
    }
    public student(string name, int id) {
        this.name = name;
        this.id = id;
    }
    
}
class results : student{
    int rank;
    double spi;
   public results(string name, int id, int rank, double spi):base(name, id){
        
        this.rank = rank;
        this.spi = spi;
    }
    public int getRank() { return rank;}
    public double getSpi() { return spi;}
    public override string ToString() {
        return base.ToString() + " Rank: " + rank + " SPI: " + spi;
    }
}

public class students{
    public static void Main(string[] args){
        
        double max = 0;
        Console.WriteLine("How many students : ");
        int n = Convert.ToInt32(Console.ReadLine());
         results[] r = new results[n];
        for(int i=0; i<n; i++){
        Console.WriteLine( "Enter Student details");
        Console.Write("Enter Name : ");
	string name = Convert.ToString(Console.ReadLine());
	Console.Write("Enter ID : ");
	int id = Convert.ToInt32(Console.ReadLine());
	Console.Write("Enter Rank : ");
	int rank = Convert.ToInt32(Console.ReadLine());
	Console.Write("Enter SPI : ");
	double spi = Convert.ToDouble(Console.ReadLine());
    r[i] = new results(name,id,rank,spi);
        }
    for (int i = 0; i < n; i++) {
    if (r[i].getRank() < 10) {
        Console.WriteLine("\nRank < 10: " + r[i]);
    }

    if (r[i].getSpi() > max) {
        max = r[i].getSpi();
        Console.WriteLine("\n\nHighest SPI: " + r[i]);
    }

    double s1 = 7.0;
    double s2 = 10.0;
    if (r[i].getSpi() > s1 && r[i].getSpi() < s2) {
        Console.WriteLine("\n\nSPI in range " + s1 + " to " + s2 + ": " + r[i]);
    }
}
}
}