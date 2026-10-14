using System;

namespace Rozumatic_OOP_Pract1
{
    // Оголошення базового класу Student
    public class Student
    {
        // Поля даних класу (Загальне завдання)
        public string Name;  // Ім'я студента
        public string Group; // Група студента

        // Нове поле для збереження середнього балу (Домашнє завдання)
        public double AverageScore;

        // Метод для красивого виведення інформації про студента на екран
        public void DisplayInfo()
        {
            Console.WriteLine($"Студент: {Name}");
            Console.WriteLine($"Група: {Group}");
            Console.WriteLine($"Середній бал: {AverageScore:F2}");
            Console.WriteLine("--------------------------------------------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========================================================================");
            Console.WriteLine("  ПРАКТИЧНЕ ЗАНЯТТЯ №1: СТВОРЕННЯ КЛАСІВ І ОБ'ЄКТІВ У C#  ");
            Console.WriteLine("==========================================================================");

            // Створення першого об'єкта класу за допомогою оператора new
            Student student1 = new Student();
            student1.Name = "Олександр Коваленко";
            student1.Group = "КН-201";
            student1.AverageScore = 4.75; // Домашнє завдання

            // Створення другого окремого об'єкта класу за допомогою оператора new
            Student student2 = new Student();
            student2.Name = "Марія Сергієнко";
            student2.Group = "КН-202";
            student2.AverageScore = 4.92; // Домашнє завдання

            Console.WriteLine("\n📊 Інформація про створених студентів:\n");
            
            // Виведення інформації на екран
            student1.DisplayInfo();
            student2.DisplayInfo();

            Console.WriteLine("✅ Програму успішно виконано!");
        }
    }
}
