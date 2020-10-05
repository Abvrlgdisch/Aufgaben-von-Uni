using System;

namespace Aufgabe_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте!");
            Console.WriteLine("Предлагаю Вам посчитать площадь и периметр прямоугольника по двум сторонам.");
            Console.WriteLine("Для этого, предлагаю Вам ввести две стороны вышеуказанной фигуры");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Площадь прямоугольника будет равна: "+ (a*b));
            Console.WriteLine("Периметр прямоугольника будет равен " + (2 * (a + b)));
        }
    }
}
