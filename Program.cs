using System;

namespace BattleSim
{
    class Program
    {
        static void Main(string[] args)
        {
            // Налаштування початкового кольору (Блакитний)
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==========================================================================");
            Console.WriteLine(" ⚔️ ПРАКТИКУМ 0: БАЗОВИЙ КОНСОЛЬНИЙ ТРЕНАЖЕР C# (BATTLESIM) ⚔️ ");
            Console.WriteLine("==========================================================================");
            Console.ResetColor();

            // 2. Запит імені героя у користувача через Console.ReadLine()
            Console.Write("\nВведіть ім'я вашого героя: ");
            string heroName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(heroName))
            {
                heroName = "Безстрашний Воїн";
            }

            // 2. Вибір зброї (1 - Меч, 2 - Лук, 3 - Посох)
            Console.WriteLine("\nОберіть вашу зброю:");
            Console.WriteLine("1 — Меч ⚔️");
            Console.WriteLine("2 — Лук 🏹");
            Console.WriteLine("3 — Посох 🪄");
            Console.Write("Ваш вибір (1-3): ");
            
            string weaponChoice = Console.ReadLine();
            string weaponName = "Кулаки";
            int minDamage = 10;
            int maxDamage = 20;

            // Визначаємо силу та назву зброї залежно від вибору (Робота умов)
            if (weaponChoice == "1")
            {
                weaponName = "Меч";
                minDamage = 15;
                maxDamage = 25;
            }
            else if (weaponChoice == "2")
            {
                weaponName = "Лук";
                minDamage = 12;
                maxDamage = 28;
            }
            else if (weaponChoice == "3")
            {
                weaponName = "Посох";
                minDamage = 18;
                maxDamage = 22;
            }

            // Кольоровий вивід статусу героя (Зелений)
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n🎭 Герой {heroName} готовий до бою, озброєний: {weaponName}!");
            Console.ResetColor();

            // 3. Параметри манекена та циклічний бій у циклі while
            int dummyHP = 100;
            int round = 1;
            Random rand = new Random();

            // Початок бою (Жовтий колір)
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n🤖 Перед вами тренувальний манекен (HP: 100). Починаємо бій!");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.ResetColor();

            // Цикл бою, поки у манекена є здоров'я (Пункт 3 завдання)
            while (dummyHP > 0)
            {
                Console.Write($"Раунд {round}: {heroName} атакує... ");
                
                // Випадкова шкода в діапазоні обраної зброї
                int damage = rand.Next(minDamage, maxDamage + 1);
                dummyHP -= damage;

                // Якщо здоров'я впало нижче нуля, прирівнюємо до 0
                if (dummyHP < 0) dummyHP = 0;

                // Кольоровий вивід результату удару (Червоний колір для шкоди)
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"-{damage} HP! ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($"(У манекена залишилось: {dummyHP} HP)");
                Console.ResetColor();

                round++;
                System.Threading.Thread.Sleep(500); // Невелика пауза для реалістичності бою
            }

            // Фінал бою (Зелений колір перемоги)
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n==========================================================================");
            Console.WriteLine($" 🎉 ПЕРЕМОГА! Манекен знищено за {round - 1} раундів! 🎉");
            Console.WriteLine("==========================================================================");
            Console.ResetColor();
        }
    }
}
