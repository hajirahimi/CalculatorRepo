﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Converter
    {
        public static double ConverterToDouble(string input)
        {
            bool successfullConversion = double.TryParse(input, out double number);
            if (!successfullConversion)
            {
                throw new Exception(" Please enter a valid Number");
            }
            return number;
        }
    }
}