using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Snake
{
    class Wall2 : GameObject
    {
        public Wall2(char sign) : base(sign)
        {
            LoadLevel2(2);
        }

        public void LoadLevel2(int level)
        {
            string name = string.Format("Level2.txt");
            StreamReader sr = new StreamReader(name);

            int r = 0;
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                for (int c = 0; c < line.Length; ++c)
                {
                    if (line[c] == '#')
                    {
                        body.Add(new Point { X = c, Y = r });
                    }
                }
                r++;
            }

            sr.Close();
        }
    }
}