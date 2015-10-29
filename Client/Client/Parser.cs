using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Client.Objects;

namespace Client
{
    class Parser
    {
        Map map;

        public Parser(Map map)
        {
            this.map = map;
        }

        public void UpdateMap(String newCome)
        {
            Console.WriteLine(newCome);
            char x = newCome[0];
            switch (x)
            {
                case 'I':
                    {
                        String str = newCome.Substring(5,newCome.Length-7);
                        String[] sub = str.Split(':');

                        // Adding bricks
                        String[] bricks = sub[0].Split(';');
                        for (int i = 0; i < bricks.Length; ++i)
                        {
                            String[] bc = bricks[i].Split(',');
                            int row = Int32.Parse(bc[0]);
                            int col = Int32.Parse(bc[1]);

                            Brick b = new Brick(100);

                            map.setSpot(row, col, b);
                        }

                        //adding stones
                        String[] stones = sub[1].Split(';');
                        for (int i = 0; i < stones.Length; ++i)
                        {
                            String[] st = stones[i].Split(',');
                            int row = Int32.Parse(st[0]);
                            int col = Int32.Parse(st[1]);

                            Stone s = new Stone();

                            map.setSpot(row, col, s);
                        }


                        //adding water
                        String[] water = sub[2].Split(';');
                        for (int i = 0; i < water.Length; ++i)
                        {
                            String[] wt = water[i].Split(',');
                            int row = Int32.Parse(wt[0]);
                            int col = Int32.Parse(wt[1]);

                            Water w = new Water();

                            map.setSpot(row, col, w);
                        }
                        break;
                    }
                case 'G':

                    break;
                case 'L':

                    break;
                case 'C':

                    break;

            }
        }
    }
}
