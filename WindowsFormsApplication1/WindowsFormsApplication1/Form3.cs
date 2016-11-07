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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void fillingTheCheckListAndRefreshingIt()
        {
            //code for reading account file and and populating checkboxes
            string accountNameForFillingCheckBoxes;
            checkedListForDeletion.Items.Clear();
            try
            {
                using (StreamReader readsTheAccountsFile = new StreamReader("..\\..\\Accounts.txt"))
                {
                    while ((accountNameForFillingCheckBoxes = readsTheAccountsFile.ReadLine()) != null)
                    {
                        checkedListForDeletion.Items.Add(accountNameForFillingCheckBoxes, false);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Not found");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            fillingTheCheckListAndRefreshingIt();
        }

        private void deleteFromCheckListButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter deleteLines = new StreamWriter("..\\..\\Accounts.txt", false))
                {
                    deleteLines.Write("");
                    deleteLines.Close();
                    deleteLines.Dispose();
                }

            }
            catch
            {

            }
            for (int i = 0; i < checkedListForDeletion.Items.Count; i++)
            {
                if (!checkedListForDeletion.GetItemChecked(i))
                {
                    try
                    {
                        using (StreamWriter deleteLines = new StreamWriter("..\\..\\Accounts.txt", true))
                        {
                            deleteLines.WriteLine(checkedListForDeletion.GetItemText(checkedListForDeletion.Items[i]));
                            deleteLines.Close();
                            deleteLines.Dispose();
                        }
                        Hide();
                    }
                    catch
                    {

                    }
                }
            }
        }
    }
}
