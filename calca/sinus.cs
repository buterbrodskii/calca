using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calca
{
    internal class sinus
    {
        public double Sine()
        {
            Console.WriteLine("Введите число (в градусах):");
            double number = Convert.ToDouble(Console.ReadLine());
            return Math.Sin(number * Math.PI / 180);
        }
    }
}
