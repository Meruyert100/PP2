using System;

namespace Task2
{
    class Student//create a class Student
    {
        public string name;//creating variable string
        public string id;//creating variable string

       
        public Student(string name, string id)//constructor with two parameters
        {
            this.name = name;
            this.id = id;
        }

        public void set_name(string name)//Method which can change the value of variable "name"
        {
            this.name = name;
        }

        public void set_id(string id)//Method which can change the value of variable "id"
        {
            this.id = id;
        }

        public string get_name()//fucntion which returns variable "name"
        {
            return name;//returning variable
        }

        public string get_id()//fucntion which returns variable "id"
        {
            return id;//returning variable
        }
        public int Get_year(int year)//function which return incrementing variable
        {
            year++;//incrementing variable "year"
            return year;//returning variable
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Student s = new Student("NAME", "18110230");//object creation and constructor call
            Console.WriteLine(s.get_name());//output name
            Console.WriteLine(s.get_id());//output id
            Console.WriteLine(s.Get_year(2018));//output incremented year of study
        }
    }
}
