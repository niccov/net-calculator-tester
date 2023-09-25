using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_calculator_tester
{
    public static class Calculator
    {
        public static float Add (float number1, float number2)
        {
            return number1 + number2;   
        }

        public static float Multiply (float number1, float number2)
        {
            return number1 * number2;
        }

        public static float Subtract(float number1, float number2)
        {
            return number1 - number2;
        }

        public static float Divide (float number1, float number2)
        {
            if (number1 == null || number2 == null || number1 == 0)
                throw new ArgumentException("I numeri non sono validi");
            return number1 / number2;
        }
    }
}
