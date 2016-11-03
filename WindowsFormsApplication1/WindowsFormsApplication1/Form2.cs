using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter("..\\..\\Accounts.txt", true))
                if (e.Equals(13))
                {
                    file.WriteLine("..\\..\\Accounts.txt", Text);
                }
        }
    }
}
