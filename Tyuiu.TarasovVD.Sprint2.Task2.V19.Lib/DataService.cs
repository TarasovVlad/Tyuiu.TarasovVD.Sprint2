using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TarasovVD.Sprint2.Task2.V19.Lib
{
    public class DataService : ISprint2Task2V19
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if (x >= 3 && x <= 5 && y >= 3 && y <= 7) ||
            (x >= 6 && x <= 10 && y >= 5 && y <= 7) ||
            (x >= 11 && x <= 12 && y >= 6 && y <= 11) ||
            (x >= 9 && x <= 11 && y >= 12 && y <= 14) ||
            (x == 6 && y == 8) ||
            (x == 6 && y == 9) ||
            (x == 6 && y == 10) ||
            (x == 6 && y == 11) ||
            (x == 5 && y == 11) ||
            (x == 4 && y == 11) ||
            (x == 3 && y == 11) ||
            (x == 9 && y == 4) ||
            (x == 9 && y == 3) ||
            (x == 10 && y == 4) ||
            (x == 10 && y == 3) ||
            (x == 11 && y == 3) ||
            (x == 12 && y == 3) ||
            (x == 13 && y == 6) ||
            (x == 13 && y == 7) ||
            (x == 13 && y == 8) ||
            (x == 9 && y == 11) ||
            (x == 10 && y == 11) ||
            (x == 7 && y == 13) ||
            (x == 8 && y == 13) ||
            (x == 12 && y == 14) ||
            (x == 13 && y == 14);
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
