using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите первое число:");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите второе число:");
                int num2 = int.Parse(Console.ReadLine());

                int result = num1 / num2;

                Console.WriteLine($"Результат деления: {result}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибка: введено некорректное число.");
                Console.WriteLine($"Подробнее: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Ошибка: деление на ноль невозможно.");
                Console.WriteLine($"Подробнее: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла непредвиденная ошибка.");
                Console.WriteLine($"Подробнее: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Программа завершена.");
            }
        }
    }
}
