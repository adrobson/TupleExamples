using System;
using System.Collections.Generic;
using System.Text;

namespace TupleExamples
{
    public static class DemoClass
    {
        public static (string, double, int) TupleMethod(string inputStr, double inputDouble)
        {
            string retString = "Hello " + inputStr;
            double retDouble = 1000 * inputDouble;

            return (retString, retDouble, 17);
        }

    }
}
