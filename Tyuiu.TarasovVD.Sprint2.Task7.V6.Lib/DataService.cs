using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TarasovVD.Sprint2.Task7.V6.Lib
{
    public class DataService : ISprint2Task7V6
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if (x >= -2 && x <= 2)
            {
                if ((y >= 1 && y <= 2) || (y >= -2 && y <= 0 && y >= 1 - Math.Sqrt(4 - x * x)))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
