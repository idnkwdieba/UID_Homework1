
// Программа 7 - поиск максимального числа среди 10 чисел, подсчёт среднего значения

namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            int[] nums = null;
            string str;
            int maxVal = int.MinValue;
            float avgVal = 0;

            do
            {
                try
                {
                    System.Console.Write("Введите десять числел (через пробел): ");
                    str = Console.ReadLine();
                    if (str != null)
                    {
                        nums = str.Split().Select(s => int.Parse(s)).ToArray();
                        if (nums.Length >= 10)
                        {
                            if (nums.Length > 10 ) 
                            {
                                Console.WriteLine("Количество чисел больше десяти. Лишние числа отброшены");
                            }
                            Console.Write("Обрабатываемые числа: ");
                            for (int i = 0; i < 10; i++)
                                Console.Write(i != 9? (nums[i] + ", ") : nums[i]);
                            Console.WriteLine();
                            flag = true;
                        }
                        else
                            Console.WriteLine("Количество чисел меньше десяти. Повторите ввод");
                    }
                    else
                        Console.WriteLine("Введена пустая строка. Повторите ввод");
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine("Некорректные значения. Повторите ввод");
                }
            } while (!flag);

            for (int i = 0; i < 10; i++)
            {
                maxVal = nums[i] > maxVal? nums[i] : maxVal;
                avgVal += nums[i];
            }
            avgVal /= 10;

            Console.WriteLine("Максимальное число: " + maxVal);
            Console.WriteLine("Среднее значение чисел: {0:F1}", avgVal);
        }
    }
}