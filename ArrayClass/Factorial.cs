﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClass
{
    internal class Factorial
    {
        public int n;


    public void FactorialNum(int n)
        {
            int result = 1;
                for (int i = 1; i <= n ; i++)
            {
                result=result*i;
            }
            Console.WriteLine(result);
        }
    }
}
