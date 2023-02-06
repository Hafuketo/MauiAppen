using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppen.Models
{
    public static class NumberClass
    {
        public static double DoCalculation (double val1, double val2, string operatorMath)
        {
            double result = 0;

            switch (operatorMath)
            {
                // Addition
                case "+":
                    result = val1 + val2;
                    break;
               
                //Subtraction
                case "-":
                    result = val1 - val2;
                    break;

                // Multiply
                case "×":
                    result = val1 * val2;
                    break;

                // Divide
                case "÷":
                    result = val1 / val2;
                    break;

                // Remainder
                case "%":
                    result = val1 % val2;
                    break;

                default:
                    break;
            }

            return result;
        }
    }
}
