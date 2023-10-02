using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Выберите программу:");
            Console.WriteLine("1. Игра 'Угадай число'.");
            Console.WriteLine("2. Таблица умножения.");
            Console.WriteLine("3. Вывод делителей числа.");
            Console.WriteLine("4. Выйти.");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                GuessNumber();
            }
            else if (choice == 2)
            {
                MultiplicationTable();
            }
            else if (choice == 3)
            {
                PrintDivisors();
            }
            else if (choice == 4)
            {
                break;
            }
            else
            {
                Console.WriteLine("Некорректный выбор. Попробуйте еще раз.");
            }
        }
    }

    static void GuessNumber()
    {
        Random random = new Random();
        int secretNum = random.Next(1, 101);
        int attempts = 0;

        while (true)
        {
            Console.Write("Было загадано число от 1 до 100.");
            int guess = Convert.ToInt32(Console.ReadLine());
            attempts++;

            if (guess < secretNum)
            {
                Console.WriteLine("Не верно! Загаданное число больше!");
            }
            else if (guess > secretNum)
            {
                Console.WriteLine("Не верно! Загаданное число меньше!");
            }
            else
            {
                Console.WriteLine($"Поздравляю, вы угадали! Число {secretNum} было отгадано за {attempts} попыток.");
                break;
            }
        }
    }

    static void MultiplicationTable()
    {
        Console.WriteLine("Таблица умножения от 1 до 10.");
        Console.WriteLine();

        for (int i = 1; i <= 10; i++)
        {
            string row = "";
            for (int j = 1; j <= 10; j++)
            {
                row += $"{i * j}\t";
            }
            Console.WriteLine(row);
        }
    }

    static void PrintDivisors()
    {
        Console.Write("Введите число для вывода делителей: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Делители числа {num}:");
        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}