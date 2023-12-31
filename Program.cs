using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            // Вывести слова на экран
            string word_1 = "Мир";
            string word_2 = "Труд";
            string word_3 = "Май";

            Console.WriteLine("Задание 1");
            Console.WriteLine("Вывести слова на экран");
            Console.WriteLine("a) " + word_1 + " " + word_2 + " " + word_3);

            Console.Write("b) ");
            Console.WriteLine(word_1);
            Console.WriteLine("     " + word_2);
            Console.WriteLine("         " + word_3);

            // Задание 2
            // Поменять числа местами (а может и не только числа)
            Console.WriteLine();
            Console.WriteLine("Задание 2");
            Console.WriteLine("Поменять числа местами");
            Console.WriteLine("Введите первое число");
            string num1 = Console.ReadLine();
            Console.WriteLine("Введите Второе число");
            string num2 = Console.ReadLine();
            //int num1 = Convert.ToInt32(x);
            //int num2 = Convert.ToInt32(y);
            Console.WriteLine(num2 + ", " + num1);

            // Задание 3
            // Найти длину окружности и площадь круга 
            Console.WriteLine();
            Console.WriteLine("Задание 3");
            Console.WriteLine("Найти длину окружности и площадь круга");
            Console.WriteLine("Введите радиус окружности");
            double Rad = double.Parse(Console.ReadLine());
            Console.WriteLine("Длина окружности = {0}", Math.PI * Rad * 2);
            Console.WriteLine("Площадь круга = {0}", Math.PI * Math.Pow(Rad, 2));

            // Задание 4
            // Найти косинус заданного угла 
            Console.WriteLine();
            Console.WriteLine("Задание 4");
            Console.WriteLine("Найти косинус заданного угла");
            Console.WriteLine("Укажите угол в градусах");
            double angle = double.Parse(Console.ReadLine());
            double radians = (angle * (Math.PI)) / 180;
            Console.WriteLine(Math.Cos(radians));
            

            // Задание 5
            // найти корни квадратного уравнения 
            //ax^2+bx+с
            //D=b^2-4ac
            Console.WriteLine();
            Console.WriteLine("Задание 5");
            Console.WriteLine("найти корни квадратного уравнения");
            Console.WriteLine("Введите коэфиценты квадратного уравнения (a, b, c)");
            double a, b, c, d, x1, x2;
            try
            {
                Console.Write("Введите a: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите b: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите c: ");
                c = Convert.ToDouble(Console.ReadLine());
                d = b * b - 4 * a * c;
                if (d > 0)
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    if (double.IsNaN(x1) || double.IsInfinity(x1) || double.IsNaN(x2) || double.IsInfinity(x2))
                    {
                        // Console.BackgroundColor = ConsoleColor.Magenta;
                        // Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Корней нет");
                    }
                    else
                    {
                        // Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("x1 = {0:0.00}, x2 = {1:0.00}", x1, x2);
                    }
                }
                else
                {
                    // Console.BackgroundColor = ConsoleColor.Magenta;
                    // Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Нет решения!");
                } }
            catch (Exception) {}

            // Задание 6
            // Поменять числа местами 
            // a. b присвоить значение c, а присвоить значение b, с присвоить значение а
            // b.b присвоить значение а, с присвоить значение b, а присвоить значение с.
            Console.WriteLine();
            Console.WriteLine("Задание 6");
            Console.WriteLine("Поменять три числа местами");
            Console.WriteLine("Введите число a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число c:");
            c = Convert.ToInt32(Console.ReadLine());
            (a, b, c) = (b, c, a);
            Console.Write("a) ");
            Console.WriteLine(a + " " + b + " " + c);
            (a, b, c) = (c, a, b);
            (a, b, c) = (c, a, b);
            Console.Write("b) ");
            Console.WriteLine(a + " " + b + " " + c);


            // Задание 7
            // Вывод случайных чисел 
            Console.WriteLine();
            Console.WriteLine("Задание 7");
            Console.WriteLine("Вывод случайных чисел");
            Random rnd = new Random(); //Создание объекта для генерации чисел
            int value1 = rnd.Next(); //Получить очередное (в данном случае - первое) случайное число
            int value2 = rnd.Next();
            int value3 = rnd.Next();
            int value4 = rnd.Next();
            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(value3);
            Console.WriteLine(value4);

            // Задание 8
            // Дано трехзначное число. В нем зачеркнули последнюю справа цифру и приписали ее
            // в начале. Найти полученное число.
            Console.WriteLine();
            Console.WriteLine("Задание 8");
            Console.WriteLine("Поставить последнюю цифру числа в начале");
            Console.WriteLine("Введите трёхзначное натуральное число");
            int n = Int32.Parse(Console.ReadLine()); // вводим трёхзначное натуральное число 
            int last = n % 10;
            int rest = n / 10;
            string first = Convert.ToString(last);
            string second = Convert.ToString(rest);
            rest = Convert.ToInt32(first + second);
            Console.WriteLine(rest); // выводит число как число
            Console.WriteLine(first + second); // выводит число как строку

            // Задание 9
            // Известна стоимость 1 кг конфет, 1 кг печенья и 1 кг яблок.
            // Найти стоимость всей покупки, если купили x кг конфет, у кг печенья и z кг яблок.
            Console.WriteLine();
            Console.WriteLine("Задание 9");
            Console.WriteLine("Найти общую сумму покупки");
            double x, y, z, sum, cost1, cost2, cost3;
            Console.WriteLine("Сколько кг конфет было куплено?");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Сколько кг печенья было куплено?");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Сколько кг яблок было куплено?");
            z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Сколько стоит 1кг конфет?");
            cost1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Сколько стоит 1кг печенья?");
            cost2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Сколько стоит 1кг яблок?");
            cost3 = Convert.ToDouble(Console.ReadLine());
            sum = (x * cost1) + (y * cost2) + (z * cost3);
            Console.WriteLine();
            Console.WriteLine("Cтоимость всей покупки - " + sum + "руб");
            Console.ReadKey();
        }
    }
}