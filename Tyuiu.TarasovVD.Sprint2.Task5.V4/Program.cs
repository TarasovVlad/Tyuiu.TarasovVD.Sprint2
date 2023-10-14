using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TarasovVD.Sprint2.Task5.V4.Lib;

namespace Tyuiu.TarasovVD.Sprint2.Task5.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите номер масти:");
            int numCard = Convert.ToInt32(Console.ReadLine());
            string res;
            if ((numCard < 1 ) || (numCard > 4))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "Это масти " + ds.FindCardSuit(numCard);
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);


            Console.ReadKey();
        }
    }
}
