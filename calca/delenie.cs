using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calca
{
    internal class delenie
    {
        public double Division()
        {
            Console.WriteLine("Введите делимое:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите делитель:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            if (num2 == 0)
            {
                Console.WriteLine("Ошибка: деление на ноль.");
                return double.NaN;
            }
            return num1 / num2;
        }
    }
}
