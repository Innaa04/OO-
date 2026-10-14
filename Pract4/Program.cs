using System;

namespace Rozumatic_OOP_Pract4
{
    // Опис класу Rectangle (Зміст роботи)
    public class Rectangle
    {
        // Два відкриті поля для ширини та висоти
        public double Width;
        public double Height;

        // Метод розрахунку площі: S = width * height
        public double CalculateArea()
        {
            return Width * Height;
        }

        // Метод розрахунку периметра: P = 2 * (width + height)
        public double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }

        // ДОМАШНЄ ЗАВДАННЯ: Логічний метод, який визначає, чи є прямокутник квадратом
        public bool IsSquare()
        {
            // Якщо ширина дорівнює висоті, то це квадрат
            return Width == Height;
        }

        // Метод для виведення параметрів на екран
        public void DisplayInfo(string name)
        {
            Console.WriteLine($"📐 Прямокутник {name}: Ширина = {Width}, Висота = {Height}");
            Console.WriteLine($"   Площа = {CalculateArea()}");
            Console.WriteLine($"   Периметр = {CalculatePerimeter()}");
            Console.WriteLine($"   Чи є квадратом? -> {(IsSquare() ? "Так, це квадрат! 🟥" : "Ні, звичайний прямокутник")}");
            Console.WriteLine("--------------------------------------------------------------------------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========================================================================");
            Console.WriteLine("     ПРАКТИЧНЕ ЗАНЯТТЯ №4: СТВОРЕННЯ ТА ТЕСТУВАННЯ КЛАСУ \"RECTANGLE\"    ");
            Console.WriteLine("==========================================================================");

            // Загальне завдання: Організація масиву із двох прямокутників
            Rectangle[] rectangles = new Rectangle[2];

            // Створення першого об'єкта (звичайний прямокутник)
            rectangles[0] = new Rectangle();
            rectangles[0].Width = 5.0;
            rectangles[0].Height = 8.0;

            // Створення другого об'єкта (квадрат)
            rectangles[1] = new Rectangle();
            rectangles[1].Width = 6.5;
            rectangles[1].Height = 6.5;

            Console.WriteLine("\n📊 Виведення параметрів кожного прямокутника з масиву:\n");
            
            // Виводимо параметри кожного елемента масиву через цикл
            for (int i = 0; i < rectangles.Length; i++)
            {
                rectangles[i].DisplayInfo((i + 1).ToString());
            }

            Console.WriteLine("✅ Практичну роботу №4 успішно виконано!");
        }
    }
}
