using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        Tank myTank;

        public Form1()
        {
            InitializeComponent();
            myTank = new Tank();
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            myTank.MoveUp();
        }

        private void JoinButton_Click(object sender, EventArgs e)
        {
            myTank.Connect();
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
    }
}
