using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2._2._2
{
    internal class Maths
    {
        //private List<int> numbers = new List<int>();

        public static int Add(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }
        public static decimal Add(decimal num1, decimal num2, decimal num3)
        {
            decimal sum = num1 + num2 + num3;
            return sum;
        }
        public static float Mulptiply(float num1, float num2)
        {
            float product = num1 * num2;
            return product;
        }
        public static float Multiply (float num1, float num2, float num3)
        {
            float product = num1 * num2 * num3;
            return product;
        }
    }
}
