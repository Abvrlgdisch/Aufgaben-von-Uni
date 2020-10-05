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
            Console.WriteLine("Теперь предлагаю посчитать периметр окружности.");
            Console.WriteLine("Для этого предлагаю Вам ввести диаметр окружности");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Периметр окружности примерно равен:" + c * 3.14);
            Console.WriteLine("Теперь давайте посчитаем среднее арифметическое чего-нибудь");
            int d = Convert.ToInt32(Console.ReadLine());
            int e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Среднее арифметическое: " + ((d + e) / 2));
            Console.WriteLine("А теперь давайте ещё поиграемся, и посчитаем например...");
            Console.WriteLine("Сумму, разность, произведение и частное квадратов двух каких-нибудь чиселок");
            Console.WriteLine("Короче, посчитаем, что просят в 4ом задании");
            int f = Convert.ToInt32(Console.ReadLine());
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Мы получили сумму " + (f + g) + " Разность " + (f - g) + " произведение " + (f * g));
            Console.WriteLine("А теперь, самое сложное... " + (f * f - g * g) + " это разность квадратов");
            Console.WriteLine("А теперь, напоследок, посчитаем сумму, разность, произведение и частное модулей двух чиселок");
            int h = Convert.ToInt32(Console.ReadLine());
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Итак, я немного почитерил и посчитал всё столбиком на бумажке... У меня получилось:");
            Console.WriteLine((h + i) + " " + (h - i) + " " + (h * i));
            Console.WriteLine("А вот с модулями у меня беда случилась, пришлось помучаться...");
            if (h<0)
            { h = h * (-1);}
            if (i<0)
            { i = i * (-1); }
            Console.WriteLine("Но у меня всё-таки получилось " + (h / i));

        }
    }
}
