using System;
class Program
{
    private string[] studentName = new string[10];

    public string this[int index]
    {
        get
        {
            return studentName[index];
        }
        set
        {
            studentName[index] = value;
        }
    }

    public static void Main()
    {
        Program obj = new Program();

        obj[0] = "Zuveriya";
        obj[1] = "Munshi";

        Console.WriteLine("First Name: " + obj[0]);
        Console.WriteLine("Last Name: " + obj[1]);
    }
}