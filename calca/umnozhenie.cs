using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calca
{
    internal class umnozhenie
    {
        public double Multiplication()
        {
            Console.WriteLine("Введите первое число:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            return num1 * num2;
        }
    }
}
