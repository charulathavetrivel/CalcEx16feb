using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcEx16feb
{
    public class Calc
    {
        public void Add(double n1, double n2) 
        {
            Console.WriteLine("Result after adding :\t" + (n1 + n2));
        }
        public void Sub(double n1, double n2)
        {
            Console.WriteLine("Result after Subtraction :\t" + (n1 - n2));
        }
        public void Div(double n1, double n2)
        {
            Console.WriteLine("Result after Divition :\t" + (n1 / n2));
        }
        public void Multi(double n1, double n2)
        {
            Console.WriteLine("Result after Multiplication :\t" + (n1 * n2));
        }

    }
}
