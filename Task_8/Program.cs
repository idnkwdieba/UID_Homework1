
// Программа 8 - угадывание числа, случайно сгенерированного компьютером

namespace Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randNum;
            int userInput = 0;
            int numOfAttempts = 0;

            randNum = random.Next(1,51);
            Console.WriteLine("Компьютер загадал число от 1 до 50");
            do
            {
                numOfAttempts++;
                do
                {
                    try
                    { 
                        Console.Write("Ваше число: ");
                        userInput = Convert.ToInt32(Console.ReadLine());
                        if (userInput > 0 && userInput <= 50)
                            break;
                        else
                            Console.WriteLine("Число должно быть в пределах от 1 до 50. Повторите ввод");

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Ошибка ввода. Повторите попытку");
                    }
                } while (true);

                if (userInput == randNum)
                {
                    Console.WriteLine("Число {0} успешно отгадано. Количество попыток: {1}", randNum, numOfAttempts);
                    break;
                }
                else
                    Console.WriteLine("Загаданное число {0} введённого", randNum > userInput ? "больше" : "меньше");
            } while (true);
        }
    }
}