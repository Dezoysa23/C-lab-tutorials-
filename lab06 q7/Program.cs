﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06_q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size for the 2 arrays: ");

            arrayCalculator arrayCal = new arrayCalculator(Convert.ToInt32(Console.ReadLine()));
            arrayCal.createArr();
            arrayCal.Scalar_sum();
            arrayCal.Vector_sum();
            arrayCal.Vector_product();
            arrayCal.Scalar_product();
        }
    }
}
