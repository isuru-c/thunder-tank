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
            char xx = newCome[0];
            switch (xx)
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
                            int x = Int32.Parse(bc[0]);
                            int y = Int32.Parse(bc[1]);

                            Brick b = new Brick(0);

                            map.setSpot(x, y, b);
                        }

                        //adding stones
                        String[] stones = sub[1].Split(';');
                        for (int i = 0; i < stones.Length; ++i)
                        {
                            String[] st = stones[i].Split(',');
                            int x = Int32.Parse(st[0]);
                            int y = Int32.Parse(st[1]);

                            Stone s = new Stone();

                            map.setSpot(x, y, s);
                        }


                        //adding water
                        String[] water = sub[2].Split(';');
                        for (int i = 0; i < water.Length; ++i)
                        {
                            String[] wt = water[i].Split(',');
                            int x = Int32.Parse(wt[0]);
                            int y = Int32.Parse(wt[1]);

                            Water w = new Water();

                            map.setSpot(x, y, w);
                        }
                        break;
                    }
                case 'G':
                    {
                        String str = newCome.Substring(2, newCome.Length - 4);
                        String[] sub = str.Split(':');

                        map.RemovePlayers();

                        for (int i = 0; i < sub.Length - 1; ++i)
                        {
                            String[] sub2 = sub[i].Split(';');
                            String name = sub2[0];

                            String[] cor = sub2[1].Split(',');
                            int x = Int32.Parse(cor[0]);
                            int y = Int32.Parse(cor[1]);

                            int direction = Int32.Parse(sub2[2]);
                            int whetherShot = Int32.Parse(sub2[3]);
                            int health = Int32.Parse(sub2[4]);
                            int coin = Int32.Parse(sub2[5]);
                            int points = Int32.Parse(sub2[6]);

                            Player p = new Player(name, direction, whetherShot, health, coin, points);

                            map.setSpot(x, y, p);
                        }

                        String[] bricks = sub[sub.Length - 1].Split(';');

                        for (int i = 0; i < bricks.Length; ++i)
                        {
                            String[] subb = bricks[i].Split(',');

                            int x = Int32.Parse(subb[0]);
                            int y = Int32.Parse(subb[1]);
                            int damage = Int32.Parse(subb[2]);

                            Brick b = new Brick(damage);

                            map.setSpot(x, y, b);
                        }

                            break;
                    }
                case 'L':
                    {


                        break;
                    }
                case 'C':

                    break;

            }
        }
    }
}
