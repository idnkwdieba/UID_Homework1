
// Программа 2 - поиск делителей заданного числа

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            int num = 0;

            Console.Write("Введите число для поиска его делителей: ");
            do
            {
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    flag = true;
                }
                catch (Exception ex)
                {
                    Console.Write("Некорректное значение. Пожалуйста, повторите ввод: ");
                }
            } while (!flag);
            flag = false;

            Console.Write("Делители числа {0}: ", num);
            for (int i = 2; i <= 10; i++)
            {
                if (num%i == 0)
                {
                    Console.Write((flag == true ? ", " : "") + i);
                    flag = true;
                }
            }
            Console.WriteLine();
        }
    }
}