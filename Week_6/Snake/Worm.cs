using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Worm : GameObject
    {
        const int height = 20;
        const int width = 79;
        public Worm(char sign) : base(sign)
        {
            body.Add(new Point { X = 15, Y = 15 });
        }

        public void Move(int dx, int dy)
        {
            Clear();

            for (int i = body.Count - 1; i > 0; --i)
            {
                body[i].X = body[i - 1].X;
                body[i].Y = body[i - 1].Y;
            }

            body[0].X = body[0].X + dx;
            body[0].Y = body[0].Y + dy;
        }

        public bool CheckCollision(Point p)
        {
            bool res = false;
            if (p.X == body[0].X && p.Y == body[0].Y)
            {
                res = true;
            }
            return res;
        }
        public bool CheckWall()
        {
            if(body[0].X<=0 || body[0].X >= width - 1 || body[0].Y <= 0 || body[0].Y >= height - 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void Eat(Point p)
        {
            body.Add(new Point { X = p.X, Y = p.Y });
        }
    }
}