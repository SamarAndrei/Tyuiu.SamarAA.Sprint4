﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SamarAA.Sprint4.Task2.V22.Lib
{
    public class DataService : ISprint4Task2V22
    {
        public int Calculate(int[] array)
        {
            int res = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0) res *= array[i];
            }
            int k = 0;
            if (res == 1)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 1) k += 1;
                    else k += 0;
                }
                if (k > 0) res = 1;
                else res = 0;
            }
            return res;
        }
    }
}
