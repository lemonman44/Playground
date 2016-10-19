using System;
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
        //the format of the panel1 below, one long panel in three sections, each
        //section the size of a form
        //|-----------|-----------|-----------|
        //|     0     |     1     |     2     |
        //|           |           |           |
        //|-----------|-----------|-----------|
        //the starting part of the panel when application is started is below
        public int pagePosition = 1;
        public Form1()
        {
            InitializeComponent();
        }

        //when 'compile/view' is clicked, shows section 0 of panel
        //button is on section 1
        private void button1_Click(object sender, EventArgs e)
        {
            pagePosition = 0;
            Panel1.Location = new Point(Panel1.Location.X * pagePosition, 0);
        }

        //when 'send data' is clicked, shows section 2 of panel 
        //button is on section 1
        private void button2_Click(object sender, EventArgs e)
        {
            pagePosition = 2;
            Panel1.Location = new Point(Panel1.Location.X * pagePosition, 0);
        }

        //when 'back' is clicked, shows section 1 of panel
        //button is on section 0
        private void button3_Click(object sender, EventArgs e)
        {
            pagePosition = 1;
            Panel1.Location = new Point(-ClientSize.Width, 0);
        }

        //when 'back2' is clicked, shows section 1 of panel
        //button is on section 2
        private void button4_Click(object sender, EventArgs e)
        {
            pagePosition = 1;
            Panel1.Location = new Point(-ClientSize.Width, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //variables to hold the (x, y) location of button 1 and 2
            //              width of form / 2    + width of form    - button width / 2
            int button1_X = ClientSize.Width / 2 + ClientSize.Width - button1.Width / 2;
            int button2_X = ClientSize.Width / 2 + ClientSize.Width - button2.Width / 2;
            int button1_Y = ClientSize.Height / 2 + button1.Height;
            int button2_Y = ClientSize.Height / 2 - button2.Height;

            //keeps the panel the right size in comparaison to whatever the form's size is
            Panel1.Size = new Size(ClientSize.Width * 3, ClientSize.Height);
            //keeps the panel in the right location for when form is resized
            Panel1.Location = new Point(-ClientSize.Width * pagePosition, 0);
            //keeps buttons in the correct location compared to panel1
            button1.Location = new Point(button1_X, button1_Y);
            button2.Location = new Point(button2_X, button2_Y);
            button4.Location = new Point(ClientSize.Width * 2, 0);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            //variables to hold the (x, y) location of button 1 and 2
            //              width of form / 2    + width of form    - button width / 2
            int button1_X = ClientSize.Width / 2 + ClientSize.Width - button1.Width / 2;
            int button2_X = ClientSize.Width / 2 + ClientSize.Width - button2.Width / 2;
            int button1_Y = ClientSize.Height / 2 + button1.Height;
            int button2_Y = ClientSize.Height / 2 - button2.Height;

            //keeps the panel the right size in comparaison to whatever the form's size is
            Panel1.Size = new Size(ClientSize.Width * 3, ClientSize.Height);
            //keeps the panel in the right location for when form is resized
            Panel1.Location = new Point(-ClientSize.Width * pagePosition, 0);
            //keeps buttons in the correct location compared to panel1
            button1.Location = new Point(button1_X, button1_Y);
            button2.Location = new Point(button2_X, button2_Y);
            button4.Location = new Point(ClientSize.Width * 2, 0);
        }
    }
}
