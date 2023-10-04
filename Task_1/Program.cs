
// Программа 1 - сравнение трёх чисел

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            int[] nums = null;
            string str;

            do
            {
                try
                {
                    System.Console.Write("Введите три числа для сравнения (через пробел): ");
                    str = Console.ReadLine();
                    if (str != null)
                    {
                        nums = str.Split().Select(s => int.Parse(s)).ToArray();
                        if (nums.Length == 3)
                            flag = true;
                        else
                            Console.WriteLine("Количество чисел не равно трём. Повторите ввод");
                    }
                    else
                        Console.WriteLine("Введена пустая строка. Повторите ввод");
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine("Некорректные значения. Повторите ввод");
                }
            } while (!flag);

            System.Console.WriteLine("Наибольшее число: " + 
                ((nums[0] > nums[1]) ? (nums[0] > nums[2] ? nums[0] : nums[2]) : (nums[1] > nums[2]? nums[1] : nums[2])));
        }
    }
}