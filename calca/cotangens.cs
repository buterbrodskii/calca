using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calca
{
    internal class cotangens
    {
        public double Cotangent()
        {
            Console.WriteLine("Введите число (в градусах):");
            double number = Convert.ToDouble(Console.ReadLine());
            return 1 / Math.Tan(number * Math.PI / 180);
        }
    }
}
