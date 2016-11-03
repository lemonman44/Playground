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
    public partial class SubtractCheckbox : Form
    {
        public SubtractCheckbox()
        {
            InitializeComponent();
        }

        private void SubtractCheckbox_Load(object sender, EventArgs e)
        {

            //Populates checkedListBox2
            String accountNameForFillingCheckBoxes;
            try
            {
                StreamReader file = new StreamReader("..\\..\\Accounts.txt");
                while ((accountNameForFillingCheckBoxes = file.ReadLine()) != null)
                {
                    checkedListBox2.Items.Add(accountNameForFillingCheckBoxes, false);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Not found");
            }
        }

            private void Form1_SizeChanged(object sender, EventArgs e)
        {
            checkedListBox2.Size = new Size(ClientSize.Width / 2, ClientSize.Height / 2);

            //variables to hold the (x, y) location of button 1 and 2
            //division by 2 puts the buttons into section 1
            //              width of form / 2    + width of form    - button width / 2
            int checkBoxes_X = ClientSize.Width / 2 - checkedListBox2.Width / 2;
            int checkBoxes_Y = ClientSize.Height / 2 - checkedListBox2.Height / 2;
        }
    
    }
}
