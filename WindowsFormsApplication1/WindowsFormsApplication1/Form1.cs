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
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public int pagePosition = 0;
        public Form1()
        {
            InitializeComponent();
        }

        //when 'compile/view' is clicked, shows section 0 of panel
        //button is on section 1
        //formulates data grid after button is clicked
        private void button1_Click(object sender, EventArgs e)
        {
            object[] temp = new object[100];
            FillArray data = new FillArray();
            Process process = new Process();
            pagePosition = 1;
            pageSwitch(pagePosition);
            data.setArray();
            process.setCorrectArray(data.getArray());
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    temp[j] = process.getCorrectArray()[i, j];
                }
                dataGridView1.Rows.Add(temp);
            }
            
        }

        //when 'send data' is clicked, shows section 2 of panel 
        //button is on section 1
        private void button2_Click(object sender, EventArgs e)
        {
            pagePosition = 2;
            pageSwitch(pagePosition);
        }

        //when 'back' is clicked, shows section 1 of panel
        //button is on section 0
        private void button3_Click(object sender, EventArgs e)
        {
            pagePosition = 0;
            pageSwitch(pagePosition);
        }

        //when 'back2' is clicked, shows section 1 of panel
        //button is on section 2
        private void button4_Click(object sender, EventArgs e)
        {
            pagePosition = 0;
            pageSwitch(pagePosition);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //code for reading account file and and populating checkboxes
            String accountNameForFillingCheckBoxes;
            try
            {
                StreamReader file = new StreamReader("..\\..\\Accounts.txt");
                while ((accountNameForFillingCheckBoxes = file.ReadLine()) != null)
                {
                    checkedListBox1.Items.Add(accountNameForFillingCheckBoxes, false);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Not found");
            }



            dataGridView1.Size = new Size(ClientSize.Width / 2, ClientSize.Height / 2);

            //variables to hold the (x, y) location of button 1 and 2
            //division by 2 puts the buttons into section 1
            //              width of form / 2    + width of form    - button width / 2
            int button1_X = ClientSize.Width / 2 + button1.Width;
            int button2_X = ClientSize.Width / 2 + button2.Width;
            int dataGrid_X = ClientSize.Width / 2 - dataGridView1.Width / 2;
            int dataGrid_Y = ClientSize.Height / 2 - dataGridView1.Height / 2;
            int button1_Y = ClientSize.Height / 2 + button1.Height;
            int button2_Y = ClientSize.Height / 2 - button2.Height;


            //keeps the panel the right size in comparison to whatever the form's size is
            Panel1.Size = new Size(ClientSize.Width, ClientSize.Height);
            Panel2.Size = new Size(ClientSize.Width, ClientSize.Height);
            Panel2.Visible = false;
            Panel3.Size = new Size(ClientSize.Width, ClientSize.Height);
            Panel3.Visible = false;
            
            //keeps buttons in the correct location compared to panel1
            button1.Location = new Point(button1_X, button1_Y);
            button2.Location = new Point(button2_X, button2_Y);
            dataGridView1.Location = new Point(dataGrid_X, dataGrid_Y);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            dataGridView1.Size = new Size(ClientSize.Width / 2, ClientSize.Height / 2);

            //variables to hold the (x, y) location of button 1 and 2
            //division by 2 puts the buttons into section 1
            //              width of form / 2    + width of form    - button width / 2
            int button1_X = ClientSize.Width / 2 + button1.Width;
            int button2_X = ClientSize.Width / 2 + button2.Width;
            int dataGrid_X = ClientSize.Width / 2 - dataGridView1.Width / 2;
            int dataGrid_Y = ClientSize.Height / 2 - dataGridView1.Height / 2;
            int button1_Y = ClientSize.Height / 2 + button1.Height;
            int button2_Y = ClientSize.Height / 2 - button2.Height;


            //keeps the panel the right size in comparison to whatever the form's size is
            Panel1.Size = new Size(ClientSize.Width, ClientSize.Height);
            Panel2.Size = new Size(ClientSize.Width, ClientSize.Height);
            Panel3.Size = new Size(ClientSize.Width, ClientSize.Height);

            //keeps buttons in the correct location compared to panel1
            button1.Location = new Point(button1_X, button1_Y);
            button2.Location = new Point(button2_X, button2_Y);
            dataGridView1.Location = new Point(dataGrid_X, dataGrid_Y);
        }
        private void pageSwitch(int requestPage)
        {
            if (requestPage == 0)
            {
                Panel1.Visible = true;
                Panel2.Visible = false;
                Panel3.Visible = false;
            }
            else if (requestPage == 1)
            {
                Panel1.Visible = false;
                Panel2.Visible = true;
                Panel3.Visible = false;
            }
            else if (requestPage == 2)
            {
                Panel1.Visible = false;
                Panel2.Visible = false;
                Panel3.Visible = true;
            }
        }
    }

}
