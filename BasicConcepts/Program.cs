// --- START OF FILE Program.cs ---

using System;
using System.Threading.Tasks;

// ===================================================================================
// ИНСТРУКЦИЯ:
// Этот файл разделен на 5 учебных блоков.
// Изначально активен только "Блок 1". Остальные "закомментированы".
// Чтобы активировать следующий блок, удалите символы /* в его начале и */ в его конце.
// ===================================================================================

namespace CSharpBasics_Interactive
{
    class Program
    {
        static async Task Main(string[] args)
        {   /*
            // --- Блок 1: Переменные и ввод данных ---
            Console.WriteLine("--- Блок 1: Переменные и твой первый ввод ---");

            Console.Write("Как тебя зовут? ");
            string userName = Console.ReadLine() ?? "";

            int userAge;
            Console.Write("Сколько тебе лет? ");
            // Пробуем превратить введенный текст в число. Если не получится, просим снова.
            while (!int.TryParse(Console.ReadLine(), out userAge))
            {
                Console.WriteLine("Ошибка. Пожалуйста, введи целое число.");
                Console.Write("Сколько тебе лет? ");
            }

            Console.WriteLine($"Привет, {userName}! Тебе {userAge} лет.\n");
            */

            /*  
            // --- Блок 2: Простая математика ---
            Console.WriteLine("--- Блок 2: Простая математика ---");
            
            double numberA;
            double numberB;
            //double numberA, numberB;
            
            Console.Write("Введи первое число: ");
            while (!double.TryParse(Console.ReadLine(), out numberA))
            {
                Console.WriteLine("Ошибка. Пожалуйста, введи число.");
                Console.Write("Введи первое число: ");
            }

            Console.Write("Введи второе число: ");
            while (!double.TryParse(Console.ReadLine(), out numberB))
            {
                Console.WriteLine("Ошибка. Пожалуйста, введи число.");
                Console.Write("Введи второе число: ");
            }
            
            Console.WriteLine($"Сложение: {numberA + numberB}");
            Console.WriteLine($"Деление: {numberA / numberB}\n");
            */


            /*  
            // --- Блок 3: Условия (if / else if / else) ---
            Console.WriteLine("--- Блок 3: Условия (if / else if / else) ---");
            Console.WriteLine("Я загадал число от 1 до 5. Попробуй угадать!");
            
            int secretNumber = new Random().Next(1, 6);
            int userGuess;

            Console.Write("Твоя догадка: ");
            while (!int.TryParse(Console.ReadLine(), out userGuess))
            {
                Console.WriteLine("Это не число. Попробуй еще раз.");
                Console.Write("Твоя догадка: ");
            }

            if (userGuess == secretNumber) 
            {
                Console.WriteLine("Угадал! Ты молодец!");
            }
            else if (userGuess < secretNumber) 
            {
                Console.WriteLine("Не угадал. Мое число БОЛЬШЕ.");
            }
            else 
            {
                Console.WriteLine("Не угадал. Мое число МЕНЬШЕ.");
            }
            Console.WriteLine($"(Я загадал число {secretNumber})\n");
            */


            /*
            // --- Блок 4: Циклы (FOR и WHILE) ---
            Console.WriteLine("--- Блок 4: Циклы ---");
            
            Console.WriteLine("** Цикл FOR **");
            int repeatCount;
            Console.Write("Сколько раз мне поздороваться? ");
            while (!int.TryParse(Console.ReadLine(), out repeatCount))
            {
                Console.WriteLine("Нужно ввести целое число.");
                Console.Write("Сколько раз? ");
            }
            
            for (int i = 0; i < repeatCount; i++)
            {
                Console.WriteLine($"Привет! (раз {i + 1})");
            }
            
            Console.WriteLine("\n** Цикл WHILE **");
            string secretWord = "выход";
            string userWord = "";
            
            while (userWord != secretWord)
            {
                Console.Write("Введи слово 'выход', чтобы закончить этот блок: ");
                userWord = Console.ReadLine()?.ToLower() ?? "";
            }
            Console.WriteLine("Правильно! Идем дальше.\n");
            */


            /*
            // --- Блок 5: Асинхронность (аналог корутин в Юнити) ---
            Console.WriteLine("--- Блок 5: Асинхронность (аналог корутин) ---");
            Console.WriteLine("Сейчас я запущу долгую 'загрузку', но программа не зависнет.");

            // Запускаем асинхронную задачу в фоновом режиме
            Task loadingTask = SimulateLoadingAsync();

            Console.Write("Пока идет загрузка, ответь на вопрос: 2 + 2 = ? ");
            string answer = Console.ReadLine() ?? "";
            Console.WriteLine($"Ты ответил: {answer}. А загрузка все еще идет в фоне!");

            // Теперь дождемся окончания фоновой задачи
            await loadingTask;
            Console.WriteLine("Загрузка завершена!\n");
            */




            // Эта строка нужна, чтобы консоль не закрылась сразу после выполнения кода.
            Console.WriteLine("\nНажми Enter, чтобы закрыть программу.");
            Console.ReadLine();
        }

        // Вспомогательный метод для Блока 5
        static async Task SimulateLoadingAsync()
        {
            Console.WriteLine("[Фон]: Начало загрузки...");
            for (int i = 1; i <= 3; i++)
            {
                await Task.Delay(1500); // Пауза на 1.5 секунды
                Console.WriteLine($"[Фон]: Загружено {i * 33}%...");
            }
            Console.WriteLine("[Фон]: Загрузка завершена!");
        }
    }
}
