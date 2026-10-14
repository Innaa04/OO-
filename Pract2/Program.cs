using System;

namespace Rozumatic_OOP_Pract2
{
    // Клас, що моделює математичну точку на площині
    public class Point
    {
        // Відкриті поля даних для координат типу double (Зміст роботи)
        public double X;
        public double Y;

        // Метод для виведення поточного стану (координат) точки на екран
        public void DisplayInfo(string pointName)
        {
            // Визначаємо квадрант, у якому знаходиться точка
            string quadrant = GetQuadrant();
            Console.WriteLine($"📍 Точка {pointName}: ({X}; {Y}) — {quadrant}");
        }

        // Допоміжний метод для визначення квадранта площини
        private string GetQuadrant()
        {
            if (X > 0 && Y > 0) return "I квадрант";
            if (X < 0 && Y > 0) return "II квадрант";
            if (X < 0 && Y < 0) return "III квадрант";
            if (X > 0 && Y < 0) return "IV квадрант";
            if (X == 0 && Y == 0) return "Початок координат";
            return "Знаходиться на осі координат";
        }

        // ДОМАШНЄ ЗАВДАННЯ: Метод, який обнуляє координати точки
        public void ResetToOrigin()
        {
            X = 0;
            Y = 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========================================================================");
            Console.WriteLine("     ПРАКТИЧНЕ ЗАНЯТТЯ №2: СТВОРЕННЯ ТА МОДЕЛЮВАННЯ КЛАСУ \"ТОЧКА\"      ");
            Console.WriteLine("==========================================================================");

            // Загальне завдання: Створення трьох точок у різних квадрантах за допомогою new
            Point p1 = new Point();
            p1.X = 5.5;
            p1.Y = 3.2; // I квадрант (+, +)

            Point p2 = new Point();
            p2.X = -4.8;
            p2.Y = 7.1; // II квадрант (-, +)

            Point p3 = new Point();
            p3.X = 2.3;
            p3.Y = -6.4; // IV квадрант (+, -)

            Console.WriteLine("\n📊 Стан створених точок (Загальне завдання):");
            Console.WriteLine("--------------------------------------------------------------------------");
            p1.DisplayInfo("A");
            p2.DisplayInfo("B");
            p3.DisplayInfo("C");

            // Демонстрація домашнього завдання: обнулення координат точки B
            Console.WriteLine("\n📉 Демонстрація домашнього завдання (Обнулення точки B):");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Викликаємо метод ResetToOrigin() для точки B...");
            
            p2.ResetToOrigin(); // Переносимо в (0; 0)
            
            p2.DisplayInfo("B (після обнулення)");
            Console.WriteLine("--------------------------------------------------------------------------");

            Console.WriteLine("✅ Практичну роботу №2 успішно виконано!");
        }
    }
}
