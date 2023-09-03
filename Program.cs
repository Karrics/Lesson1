using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args) // Задание 1 
        {
            string word_1 = "Мир";
            string word_2 = "Труд";
            string word_3 = "Май";

            Console.WriteLine("Задание 1");
            Console.WriteLine("a) " + word_1 + " " + word_2 + " " + word_3);

            Console.Write("b) ");
            Console.WriteLine(word_1);
            Console.WriteLine("     " + word_2);
            Console.WriteLine("         " + word_3);

            // Задание 2
            Console.WriteLine();
            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите первое число");
            string num1 = Console.ReadLine();
            Console.WriteLine("Введите Второе число");
            string num2 = Console.ReadLine();
            //int num1 = Convert.ToInt32(x);
            //int num2 = Convert.ToInt32(y);
            Console.WriteLine(num2 + ", " + num1);

            // Задание 3
            Console.WriteLine();
            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите радиус окружности");
            double Rad = double.Parse(Console.ReadLine());
            Console.WriteLine("Длина окружности = {0}", Math.PI * Rad * 2);
            Console.WriteLine("Площадь круга = {0}", Math.PI * Math.Pow(Rad, 2));

            // Задание 4
            Console.WriteLine();
            Console.WriteLine("Задание 4");
            Console.WriteLine("Укажите угол");
            double angle = double.Parse(Console.ReadLine());
            double radians = (angle * (Math.PI)) / 180;
            Console.WriteLine(Math.Cos(radians));
            Console.ReadKey();
        }                          
    }
}
