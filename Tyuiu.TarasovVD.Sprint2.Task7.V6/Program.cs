using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TarasovVD.Sprint2.Task7.V6.Lib;

namespace Tyuiu.TarasovVD.Sprint2.Task7.V6
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("Введите значение X: ");
                double x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение Y: ");
                double y = Convert.ToDouble(Console.ReadLine());
                DataService ds = new DataService();
                bool res = ds.CheckDotInShadedArea(x, y);
                Console.WriteLine();
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");
                if (res)
                {
                    Console.WriteLine("Точка находится в заштрихованной области");
                }
                else
                {
                    Console.WriteLine("Точка не находится в заштрихованной области");
                }



                Console.ReadKey();
            }
        }
    }

}
    

