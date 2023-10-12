﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TarasovVD.Sprint2.Task1.V22.Lib
{
    public class DataService : ISprint2Task1V22
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6]; //a = 324, b = 696, c = 254, d = 155

            res[0] = a < b && b > c;
            res[1] = a > c || c < d;
            res[2] = a >= c && b <= d;
            res[3] = a < c || d > b;
            res[4] = !(a == b) && (d != c);
            res[5] = !(a < c) || (c < d);
            return res;
        }
    }
}
