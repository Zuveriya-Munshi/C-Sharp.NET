using System;
    class Delegates
    {

        public delegate void add(int a, int b);
        public delegate void sub(int a, int b);

        public void sum(int a, int b)
        {
            Console.WriteLine("(10 + 6) = {0}", a + b);
        }

        public void subtract(int a, int b)
        {
            Console.WriteLine("(200 - 3) = {0}", a - b);
        }
        public static void Main(String[] args)
        {

            Delegates obj = new Delegates();
            add del_obj1 = new add(obj.sum);
            sub del_obj2 = new sub(obj.subtract);

            del_obj1(10, 6);
            del_obj2(200, 3);
        }
    }

