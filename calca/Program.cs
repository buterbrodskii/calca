using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();

        while (true)
        {
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Деление");
            Console.WriteLine("4. Умножение");
            Console.WriteLine("5. Вычисление косинуса");
            Console.WriteLine("6. Вычисление синуса");
            Console.WriteLine("7. Вычисление тангенса");
            Console.WriteLine("8. Вычисление котангенса");
            Console.WriteLine("9. Вычисление квадратного корня числа");
            Console.WriteLine("10. Вычисление квадрата");
            Console.WriteLine("11. Выход");

            Console.Write("Введите номер операции: ");
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Ошибка: введено некорректное значение.");
                continue;
            }

            double result = 0;
            double num1, num2;

            switch (choice)
            {
                case 1:
                    Console.Write("Введите первое число: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    num2 = double.Parse(Console.ReadLine());
                    result = calc.Add(num1, num2);
                    break;
                case 2:
                    Console.Write("Введите первое число: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    num2 = double.Parse(Console.ReadLine());
                    result = calc.Subtract(num1, num2);
                    break;
                case 3:
                    Console.Write("Введите делимое: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Введите делитель: ");
                    num2 = double.Parse(Console.ReadLine());
                    result = calc.Divide(num1, num2);
                    break;
                case 4:
                    Console.Write("Введите первое число: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    num2 = double.Parse(Console.ReadLine());
                    result = calc.Multiply(num1, num2);
                    break;
                case 5:
                    Console.Write("Введите угол в градусах: ");
                    num1 = double.Parse(Console.ReadLine());
                    result = calc.Cosine(num1);
                    break;
                case 6:
                    Console.Write("Введите угол в градусах: ");
                    num1 = double.Parse(Console.ReadLine());
                    result = calc.Sine(num1);
                    break;
                case 7:
                    Console.Write("Введите угол в градусах: ");
                    num1 = double.Parse(Console.ReadLine());
                    result = calc.Tangent(num1);
                    break;
                case 8:
                    Console.Write("Введите угол в градусах: ");
                    num1 = double.Parse(Console.ReadLine());
                    result = calc.Cotangent(num1);
                    break;
                case 9:
                    Console.Write("Введите число: ");
                    num1 = double.Parse(Console.ReadLine());
                    result = calc.SquareRoot(num1);
                    break;
                case 10:
                    Console.Write("Введите число: ");
                    num1 = double.Parse(Console.ReadLine());
                    result = calc.Square(num1);
                    break;
                case 11:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Ошибка: неверный выбор операции.");
                    continue;
            }

            Console.WriteLine($"Результат: {result}\n");
        }
    }
}