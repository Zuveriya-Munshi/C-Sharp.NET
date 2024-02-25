using System;
using System.Threading;
class Buffer
{
    private int info;
    private volatile int flag = 0;
    public Buffer()
    {
        flag = 0;
    }
    public void Put(int n)
    {
        lock (this)
        {
            if (flag == 1)
            {
                try
                {
                    Monitor.Wait(this);
                }
                catch (ThreadInterruptedException)
                {
                    Console.WriteLine("Interrupted Exception");
                }
            }
            flag = 1;
            info = n;
            Monitor.Pulse(this);
        }
    }
    public void Get()
    {
        lock (this)
        {
            if (flag == 0)
            {
                try
                {
                    Monitor.Wait(this);
                }
                catch (ThreadInterruptedException)
                {
                    Console.WriteLine("Interrupted Exception");
                }
            }
            Console.WriteLine("Information : " + info);
            flag = 0;
            Monitor.Pulse(this);
        }
    }
}
class Producer
{
    private Buffer b_ref;
    private int pid;
    public Producer(Buffer b, int id)
    {
        b_ref = b;
        pid = id;
        Thread t = new Thread(Run);
        t.Start();
    }
    public void Run()
    {
        for (int i = 0; i < 5; i++)
        {
            b_ref.Put(i);
            try
            {
                Thread.Sleep(100);
            }
            catch (ThreadInterruptedException)
            {
                Console.WriteLine("Interrupted Exception");
            }
        }
    }
}
class Consumer
{
    private Buffer b_ref;
    private int cid;
    public Consumer(Buffer b, int id)
    {
        b_ref = b;
        cid = id;
        Thread t = new Thread(Run);
        t.Start();
    }
    public void Run()
    {
        for (int i = 0; i < 5; i++)
        {
            b_ref.Get();
            try
            {
                Thread.Sleep(100);
            }
            catch (ThreadInterruptedException)
            {
                Console.WriteLine("Interrupted Exception");
            }
        }
    }
}
class PC
{
    public static void Main(string[] args)
    {
        Buffer b_ref_main = new Buffer();
        Producer p_ref = new Producer(b_ref_main, 0);
        Consumer c_ref = new Consumer(b_ref_main, 0);
        try
        {
            p_ref.Run();
            c_ref.Run();
        }
        catch (ThreadInterruptedException)
        {
            Console.WriteLine("Interrupted Exception");
        }
    }
}