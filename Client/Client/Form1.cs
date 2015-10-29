using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Client.Objects;

namespace Client
{
    public partial class Form1 : Form
    {
        Tank myTank;
        Map map;

        public Form1()
        {
            InitializeComponent();
            map = new Map(10);
            myTank = new Tank(new Parser(map));
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            myTank.MoveUp();
        }

        private void JoinButton_Click(object sender, EventArgs e)
        {
            myTank.Connect();
            draw();
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            myTank.MoveRight();
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            myTank.MoveLeft();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            myTank.MoveDown();
        }

        private void ShootButton_Click(object sender, EventArgs e)
        {
            myTank.Shoot();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void draw()
        {
            Graphics g = mp.CreateGraphics();
            Brush b;

            int size = map.mapSize;

            Rectangle r = new Rectangle(0, 0, size*50, size*50);
            b = new SolidBrush(Color.Yellow);

            g.FillRectangle(b, r);

            for (int row = 0; row < size; ++row)
            {
                for (int col = 0; col < size; ++col)
                {
                    r = new Rectangle(row*50, col*50, 50, 50);
                    MapObject map_o = map.getSpot(row, col);

                    if (map_o == null)
                        continue;
                    else if (map_o is Water)
                    {
                        b = new SolidBrush(Color.Blue);
                        g.FillRectangle(b, r);
                    }
                    else if (map_o is Stone)
                    {
                        b = new SolidBrush(Color.Black);
                        g.FillRectangle(b, r);
                    }
                    else if (map_o is Brick)
                    {
                        b = new SolidBrush(Color.Brown);
                        g.FillRectangle(b, r);
                    }

                }
            }

                
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine(e.KeyChar);
            if (e.KeyChar == 97)
            {
                
            }
        }
        


       

      
    }
}
