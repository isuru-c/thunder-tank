using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Tank_Last_Version.objects;

namespace Tank_Last_Version
{
    class Parser
    {
        Map map;
        public Parser(Map map) { this.map = map; }

        public void UpdateMap(String newMessage)
        {
            // Console.WriteLine(newCome);
            char message_type = newMessage[0];
            char message_identifier = newMessage[1];

            if (message_identifier == ':')
            {
                switch (message_type)
                {
                    case 'I':
                        {
                            String str = newMessage.Substring(5, newMessage.Length - 7);
                            String[] sub = str.Split(':');

                            // Adding bricks
                            String[] bricks = sub[0].Split(';');
                            for (int i = 0; i < bricks.Length; ++i)
                            {
                                String[] bc = bricks[i].Split(',');
                                int x = Int32.Parse(bc[0]);
                                int y = Int32.Parse(bc[1]);

                                Brick b = new Brick(x,y,0);

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
                            String str = newMessage.Substring(2, newMessage.Length - 4);
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

                                Tank t = new Tank(x,y,name, direction, whetherShot, health, coin, points);

                                map.setSpot(x, y, t);
                            }

                            String[] bricks = sub[sub.Length - 1].Split(';');

                            for (int i = 0; i < bricks.Length; ++i)
                            {
                                String[] subb = bricks[i].Split(',');

                                int x = Int32.Parse(subb[0]);
                                int y = Int32.Parse(subb[1]);
                                int damage = Int32.Parse(subb[2]);

                                Brick b = new Brick(x,y,damage);

                                map.setSpot(x, y, b);
                            }

                            break;
                        }
                    case 'L':
                        {

                            String str = newMessage.Substring(2, newMessage.Length - 4);
                            String[] sub = str.Split(':');

                            String[] cor = sub[0].Split(',');

                            int x = Int32.Parse(cor[0]);
                            int y = Int32.Parse(cor[1]);

                            int time = Int32.Parse(sub[1]);

                            LifePack lp = new LifePack(x,y,time);

                            map.setSpot(x, y, lp);

                            break;
                        }
                    case 'C':
                        {
                            String str = newMessage.Substring(2, newMessage.Length - 4);
                            String[] sub = str.Split(':');

                            String[] cor = sub[0].Split(',');

                            int x = Int32.Parse(cor[0]);
                            int y = Int32.Parse(cor[1]);

                            int time = Int32.Parse(sub[1]);

                            int value = Int32.Parse(sub[2]);

                            Coin lp = new Coin(x,y,time, value);

                            map.setSpot(x, y, lp);

                            break;
                        }
                }
            }
            else
            {
                //A messege came out
                Console.WriteLine(newMessage);
            }
        }

    }
}
