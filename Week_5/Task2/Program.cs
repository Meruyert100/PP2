using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Task2
{
    public class Mark
    {
        public int points;

        public string mark;

        public Mark()
        {

        }
        public Mark(int points)
        {
            this.points = points;
        }

        public int Point
        {
            get
            {
                return points;
            }
        }

        public string GetLetter(int points)
        {
            if (points >= 95 && points <= 100)
            {
                mark = "A";
            }
            else if (points >= 90 && points <= 94)
            {
                mark = "A-";
            }
            else if (points >= 85 && points <= 89)
            {
                mark = "B+";
            }
            else if (points >= 80 && points <= 84)
            {
                mark = "B";
            }
            else if (points >= 75 && points <= 79)
            {
                mark = "B-";
            }
            else if (points >= 70 && points <= 74)
            {
                mark = "C+";
            }
            else if (points >= 65 && points <= 69)
            {
                mark = "C";
            }
            else if (points >= 60 && points <= 64)
            {
                mark = "C-";
            }
            else if (points >= 55 && points <= 59)
            {
                mark = "D+";
            }
            else if (points >= 50 && points <= 54)
            {
                mark = "D";
            }
            else if (points >= 0 && points <= 49)
            {
                mark = "F";
            }
            return mark;
        }

        public override string ToString()
        {

            return string.Format(points + " is " + GetLetter(points));
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Mark m = new Mark(90);
            Mark m2 = new Mark(73);
            Console.WriteLine(m.ToString());
            Console.WriteLine(m2.ToString());
            List<Mark> marks = new List<Mark>();
            marks.Add(m);
            marks.Add(m2);
            Ser(marks);
            Deser();

        }
        static void Ser(List<Mark> c)
        {
            FileStream fs = new FileStream("marks.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(List<Mark>));
            xs.Serialize(fs, c);
            fs.Close();
        }
        static void Deser()
        {
            FileStream fs = new FileStream("marks.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(List<Mark>));
            List<Mark> t = xs.Deserialize(fs) as List<Mark>;
            fs.Close();
        }
    }
}
