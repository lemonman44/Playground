﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //the format of the panel below, one long panel in three sections, each
        //section the size of a form
        //|-----------|-----------|-----------|
        //|     0     |     1     |     2     |
        //|           |           |           |
        //|-----------|-----------|-----------|
        //the starting part of the panel when application is started is below
        private int pagePosition = 1;
        public Form1()
        {
            InitializeComponent();
        }
        //code for when button1 is pressed
        private void button1_Click(object sender, EventArgs e)
        {
            pagePosition = 0;
            button3.Visible = true;
            Panel1.Location = new Point(Panel1.Location.X + ClientSize.Width, 0);
            button1.Visible = false;
            button2.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            pagePosition = 2;
            button3.Visible = true;
            Panel1.Location = new Point(Panel1.Location.X - ClientSize.Width, 0);
            button1.Visible = false;
            button2.Visible = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            pagePosition = 1;
            button3.Visible = false;
            Panel1.Location = new Point(Panel1.Location.X - ClientSize.Width, 0);
            button1.Visible = true;
            button2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pagePosition = 1;
            button3.Visible = false;
            Panel1.Location = new Point(Panel1.Location.X + ClientSize.Width, 0);
            button1.Visible = true;
            button2.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int button1_X = ClientSize.Width / 2 + ClientSize.Width - button1.Width / 2;
            int button2_X = ClientSize.Width / 2 + ClientSize.Width - button2.Width / 2;
            int button1_Y = ClientSize.Height / 2 + button1.Height;
            int button2_Y = ClientSize.Height / 2 - button2.Height;

            Panel1.Size = new Size(ClientSize.Width * 3, ClientSize.Height);
            Panel1.Location = new Point(-ClientSize.Width * pagePosition, 0);
            button1.Location = new Point(button1_X, button1_Y);
            button2.Location = new Point(button2_X, button2_Y);
            button4.Location = new Point(ClientSize.Width * 2, 0);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            int button1_X = ClientSize.Width / 2 + ClientSize.Width - button1.Width / 2;
            int button2_X = ClientSize.Width / 2 + ClientSize.Width - button2.Width / 2;
            int button1_Y = ClientSize.Height / 2 + button1.Height;
            int button2_Y = ClientSize.Height / 2 - button2.Height;

            Panel1.Size = new Size(ClientSize.Width * 3, ClientSize.Height);
            Panel1.Location = new Point(-ClientSize.Width * pagePosition, 0);
            button1.Location = new Point(button1_X, button1_Y);
            button2.Location = new Point(button2_X, button2_Y);
            button4.Location = new Point(ClientSize.Width * 2, 0);
        }
    }
}
