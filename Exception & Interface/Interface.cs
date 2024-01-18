using System;
namespace ConsoleApp1
{
    interface I
    {
        void ShowName();
        void ShowDescription();
    }
    class Name : I 
    {
        //Console.WriteLine("Enter Your name : ");
        protected string name = Console.ReadLine();
        public string getName()
        {
            return name;
        }
        public void ShowNm()
        {
            Console.WriteLine("From class : Name : " +  getName());
        }
        public void ShowDescription()
        {
            Console.Write("From Interface ");
        }
        public void ShowName()
        {
          
            Console.WriteLine(" Name :Zuveriya");
        } 
        

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Name n = new Name();
            string name = n.getName();
            n.ShowNm();
            n.ShowDescription();
            n.ShowName();
            
        }
    }
}
