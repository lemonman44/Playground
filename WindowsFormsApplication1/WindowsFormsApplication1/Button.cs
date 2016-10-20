using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Data
    {
        int[,] number_Storage = new int[100, 100];
        public void populateArray()
        {
            Random random = new Random();
          
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    number_Storage[i, j] = random.Next(1, 100);
                }
            }
        }
        public int[,] getArray()
        {
            return number_Storage;
        }
    }
}
