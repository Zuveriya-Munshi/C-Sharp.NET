using System;
interface Shape
{
    public void area();
}
class circle : Shape
{
    protected double  pi = 3.14;
    //Console.WriteLine("Enter Radius of Circle : ");
    protected int rad = Convert.ToInt32(Console.ReadLine());
    public void area()
    {
        double ans = pi * rad * rad;
        Console.WriteLine("Circle Area : " + ans);
    }
}
class square : Shape
{
    //Console.WriteLine("Enter side of Square : ");
   
    protected int s = Convert.ToInt32(Console.ReadLine());
    public void area()
    {
        double ans = s * s;
        Console.WriteLine("Square Area : " + ans);
    }
}
class Inter()
{
    public static void Main(string[] args)
    {
        circle c = new circle();
        c.area();
        square s = new square();
        s.area();
    }
}
