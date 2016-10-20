using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Process
    {
        int[,] correctArray = new int[100, 100];
        int[] tempArray = new int[100];
        public void setCorrectArray(int[,] correctArray)
        {
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    tempArray[j] = correctArray[i, j];
                }
                Array.Sort(tempArray);
                for (int k = 0; k < 100; k++)
                {
                    this.correctArray[i, k] = tempArray[k];
                }
            }
        }
        public int[,] getCorrectArray()
        {
            return correctArray;
        }
    }
}
