using System;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        class MyThread
        {
            Thread threadfield;

            public MyThread(string name) //Конструктор получает имя функции и номер до кторого ведется счет
            {

                threadfield = new Thread(this.StartThread);
                threadfield.Name = name;
                threadfield.Start();//передача параметра в поток
            }


            void StartThread()//Функция потока, передаем параметр
            {
                for (int i = 1; i <= 4; i++)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " выводит " + i);
                    Thread.Sleep(2000);
                }
                Console.WriteLine(Thread.CurrentThread.Name + " завершился");
            }


        }

        static void Main(string[] args)
        {
            MyThread t1 = new MyThread("Thread 1");
            MyThread t2 = new MyThread("Thread 2");
            MyThread t3 = new MyThread("Thread 3");

            Console.Read();

        }

    }
}