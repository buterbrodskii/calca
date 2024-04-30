using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calca
{
    internal class tangens
    {
        public double Tangent()
        {
            Console.WriteLine("Введите число (в градусах):");
            double number = Convert.ToDouble(Console.ReadLine());
            return Math.Tan(number * Math.PI / 180);
        }
    }
}
