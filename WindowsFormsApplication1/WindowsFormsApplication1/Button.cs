using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Button
    {
        static void Main()
        {
            Random random = new Random();
            int[,] number_Storage = new int[100, 100];
            int y = 100;
            int x = 100;
            while (y != 0)
            {
                while (x != 0)
                {
                    number_Storage[x-1, y-1] = random.Next(1, 100);
                    x--;
                }
                y--;
            }
        }
    }
}
