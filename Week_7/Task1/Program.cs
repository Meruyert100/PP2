using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskSample
{
    class Threads
    {

        // Method of Threads class 
        public void value()
        {
            // Fetching the name of  
            // the current thread 
            // Using Name property 
            Thread thr = Thread.CurrentThread;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("The name of the current " +
                                   "thread is: " + thr.Name);
                Thread.Sleep(2000);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Threads obj = new Threads();

            Thread thr1 = new Thread(obj.value);
            Thread thr2 = new Thread(obj.value);
            Thread thr3 = new Thread(obj.value);

            thr1.Name = "1";
            thr2.Name = "2";
            thr3.Name = "3";

            thr1.Start();
            thr2.Start();
            thr3.Start();
        }

    }
}