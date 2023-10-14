using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TarasovVD.Sprint2.Task6.V15.Lib
{
    public class DataService : ISprint2Task6V15
    {
        public string FindDayName(int k)
        {

            int StartDay = 0;
            int dayOfWeek = (StartDay + (k - 1)) % 7;
            switch (dayOfWeek)
            {
                case 0: return "Понедельник";
                case 1: return "Вторник";
                case 2: return "Среда";
                case 3: return "Четверг";
                case 4: return "Пятница";
                case 5: return "Суббота";
                case 6: return "Воскресенье";
                default: throw new ArgumentException("Недопустимое значение k. Допустимы значения от 1 до 365.");


            }
            

        }
    }
}
