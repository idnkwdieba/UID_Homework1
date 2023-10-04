
// Программа 5 - вывод количества четных и нечетных чисел

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            int num = 0;

            do
            {
                try
                {
                    System.Console.Write("Введите целое положительное число: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    if (num > 0 )
                    {
                        System.Console.WriteLine("Количество четных чисел: " + num / 2);
                        System.Console.WriteLine("Количество нечетных чисел: " + (num / 2 + num % 2));
                        flag = true;
                    }
                    else
                    {
                        System.Console.WriteLine("Число не является положительным. Повторите ввод");
                    }
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine("Некорректные значения. Повторите ввод");
                }
            } while (!flag);
        }
    }
}