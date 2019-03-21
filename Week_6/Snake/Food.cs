using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Food : GameObject
    {
        const int height = 20;
        const int width = 79;
        public Food(char sign) : base(sign)
        {
            Generate();
        }
        public void Generate()
        {
            Random random = new Random(DateTime.Now.Second);
            body.Clear();
            body.Add(new Point
            {
                X = random.Next(1, width-1),
                Y = random.Next(1, height-1)
            });
        }
    }
}