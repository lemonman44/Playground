using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Process
    {

        string file;
        string storesEachRowAsStringForFurtherParsing;
        String[] arrayForStoringTheRowsOnlySeperatedNow = new String[27];
        
        public void sortEachRow(OpenFileDialog openFileDialog1, DataGridView dataGridView1)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                file = openFileDialog1.FileName;
            }
            try
            {
                StreamReader readsTheCSV = new StreamReader(file);
                while ((storesEachRowAsStringForFurtherParsing = readsTheCSV.ReadLine()) != null)
                {
                    int positionInTheString = 0;
                    for (int i = 0; i < 27; i++)
                    {
                        for (; positionInTheString < storesEachRowAsStringForFurtherParsing.Length 
                            && storesEachRowAsStringForFurtherParsing.ElementAt(positionInTheString) != 44; 
                            positionInTheString++)
                        {
                            arrayForStoringTheRowsOnlySeperatedNow[i] +=
                                storesEachRowAsStringForFurtherParsing.ElementAt(positionInTheString);
                        }
                        if (storesEachRowAsStringForFurtherParsing.ElementAt(positionInTheString) == 44
                            && positionInTheString != storesEachRowAsStringForFurtherParsing.Length - 1)
                        {
                            positionInTheString++;
                        }
                        
                    }

                    dataGridView1.Rows.Add(arrayForStoringTheRowsOnlySeperatedNow);
                    for (int i = 0; i < 27; i++)
                    {
                        arrayForStoringTheRowsOnlySeperatedNow[i] = "";
                    }
                }
            }
            catch
            {
                Console.WriteLine("CSV file not found");
            }
        }
    }
}
