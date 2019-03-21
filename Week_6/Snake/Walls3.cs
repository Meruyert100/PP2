using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Snake
{
    class Wall3 : GameObject
    {
        public Wall3(char sign) : base(sign)
        {
            LoadLevel3(3);
        }

        public void LoadLevel3(int level)
        {
            string name = string.Format("Level3.txt");
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