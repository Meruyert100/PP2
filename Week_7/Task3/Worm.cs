﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Worm : GameObject
    {
        const int height = 20;
        const int width = 40;
        public int Dx
        {
            get;
            set;
        }

        public int Dy
        {
            get;
            set;
        }

        public Worm() : base()
        {

        }
        public Worm(char sign) : base(sign)
        {
            body.Add(new Point(10, 10));
            Dx = Dy = 0;
        }
        public void Move()
        {
            Clear();
            for (int i = body.Count - 1; i > 0; --i)
            {
                body[i].X = body[i - 1].X;
                body[i].Y = body[i - 1].Y;
            }
            body[0].X += Dx;
            body[0].Y += Dy;
        }
        public bool IsIntersected(List<Point> points)
        {
            bool res = false;

            foreach (Point p in points)
            {
                if (p.X == body[0].X && p.Y == body[0].Y)
                {
                    res = true;
                    break;
                }
            }

            return res;
        }
        public bool CheckWall()
        {
            if (body[0].X <= 0 || body[0].X >= width - 1 || body[0].Y <= 0 || body[0].Y >= height - 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public void Eat(List<Point> body)
        {
            this.body.Add(new Point(body[0].X, body[0].Y));
        }
    }
}