using System;

namespace Rozumatic_OOP_Pract3
{
    // Клас, що моделює геометричне коло (Circle)
    public class Circle
    {
        // Відкрите поле даних для радіуса кола (Зміст роботи)
        public double Radius;

        // Метод для обчислення площі кола: S = PI * r^2
        public double CalculateArea()
        {
            // Використовуємо вбудовану константу Math.PI та функцію Math.Pow для піднесення до квадрату
            return Math.PI * Math.Pow(Radius, 2);
        }

        // Метод для обчислення довжини кола: L = 2 * PI * r
        public double CalculateCircumference()
        {
            return 2 * Math.PI * Radius;
        }

        // Метод для красивого виведення характеристик кола на екран
        public void DisplayInfo(string circleName)
        {
            Console.WriteLine($"⚪ Коло {circleName}: Радіус = {Radius:F2}");
            Console.WriteLine($"   📐 Площа (S) = {CalculateArea():F4}");
            Console.WriteLine($"   📏 Довжина (L) = {CalculateCircumference():F4}");
            Console.WriteLine("--------------------------------------------------------------------------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==========================================================================");
            Console.WriteLine("       ПРАКТИЧНЕ ЗАНЯТТЯ №3: СТВОРЕННЯ ТА РОЗРАХУНОК КЛАСУ \"КОЛО\"      ");
            Console.WriteLine("==========================================================================");
            Console.ResetColor();

            // Створення першого об'єкта кола з невеликим радіусом
            Circle c1 = new Circle();
            c1.Radius = 5.0;

            // Створення другого об'єкта кола з дробовим радіусом
            Circle c2 = new Circle();
            c2.Radius = 12.65;

            Console.WriteLine("\n📊 Результати розрахунків геометричних параметрів:");
            Console.WriteLine("--------------------------------------------------------------------------");
            
            // Виклик методів та друк інформації
            c1.DisplayInfo("A");
            c2.DisplayInfo("B");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("✅ Практичну роботу №3 успішно виконано!");
            Console.ResetColor();
        }
    }
}
