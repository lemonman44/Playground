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

        
        
        public string newCompanyName = "";

        public Form2()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine(e.KeyChar);
            if (e.KeyChar == 13)
            {
                try
                {
                    using (StreamWriter file = File.AppendText("..\\..\\Accounts.txt"))
                    {
                        Console.WriteLine("Added a company");
                        file.WriteLine(newCompanyName);
                        file.Close();
                        file.Dispose();
                    }
                    
                    Hide();
                }
                catch (Exception g)
                {
                    Console.WriteLine(g);
                }
            }
            else
            {
                newCompanyName += e.KeyChar.ToString();
            }
        }
    }
}
