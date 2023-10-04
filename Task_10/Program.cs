
// Программа 10 - компьютер отгадывает число, загаданное пользователем

namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int bottomBorder = 1;
            int topBorder = 101;
            int guess;
            bool flag = false;
            int ctr = 0;
            ConsoleKey userInput;

            Console.WriteLine("Загадайте число от 1 до 100. Компьютер попытается его отгадать");
            Console.WriteLine("Считываемые клавиши: \nY - ответ верный \nG - загаданное число больше " +
                "\nL - загаданное число меньше");

            do
            {
                ctr++;
                guess = rand.Next(bottomBorder,topBorder);
                do
                {
                    Console.WriteLine("\nЗагаданное вами число - {0}?", guess);
                    userInput = Console.ReadKey().Key;

                    switch (userInput)
                    {
                        case ConsoleKey.Y:
                            flag = true;
                            break;
                        case ConsoleKey.G:
                            bottomBorder = guess+1;
                            flag = true;
                            break;
                        case ConsoleKey.L:
                            topBorder = guess-1;
                            flag = true;
                            break;
                        default:
                            Console.Write("\nОшибка ввода. Повторите попытку");
                            break;
                    }

                    if (flag)
                    {
                        flag = false;
                        break;
                    }
                } while (true);

                if (userInput == ConsoleKey.Y)
                {
                    Console.WriteLine("\nКомпьютер отгадал ваше число за {0} попыток", ctr);
                    break;
                }
            } while (true);
        }
    }
}