using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Food : GameObject
    {
        const int height = 20;
        const int width = 40;
        public Food(char sign) : base(sign)
        {
        }

        public Food() : base() { }

        public void GenerateLocation(List<Point> wormBody, List<Point> wallBody)
        {
            body.Clear();
            Random random = new Random(DateTime.Now.Second);

            Point p = new Point(random.Next(1, width - 3), random.Next(1, height - 3));

            while (!IsGoodPoint(p, wormBody) || !IsGoodPoint(p, wallBody))
            {
                p = new Point(random.Next(1, width - 3), random.Next(1, width - 3));
            }
            body.Add(p);
        }

        bool IsGoodPoint(Point p, List<Point> points)
        {
            bool res = true;

            foreach (Point t in points)
            {
                if (p.X == t.X && p.Y == t.Y)
                {
                    res = false;
                    break;
                }
            }

            return res;
        }
    }
}