
// Программа 6 - поиск в заданном диапазоне чисел, делящихся на 3, 5, 9

namespace Task_6
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // botB - нижняя граница, topB - верхняя граница, n - делитель
            void countNums(int botB, int topB, int n)
            {
                int ctr = topB/n - botB/n + (botB%n == 0? 1:0);
                Console.WriteLine("Количество чисел, делящихся на {0}: {1}", n, ctr);
            }

            bool flag = false;
            int numA = 0;
            int numB = 0;

            do
            {
                try
                {
                    System.Console.Write("Введите нижнюю границу: ");
                    numA = Convert.ToInt32(Console.ReadLine());
                    System.Console.Write("Введите верхнюю границу: ");
                    numB = Convert.ToInt32(Console.ReadLine());
                    if (numA > 0 && numB > 0)
                        if (numA <= numB)
                            flag = true;
                        else
                            System.Console.WriteLine("Нижняя граница больше верхней. Повторите ввод");
                    else
                        System.Console.WriteLine("Число не является положительным. Повторите ввод");
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine("Некорректные значения. Повторите ввод");
                }
            } while (!flag);

            countNums(numA, numB, 3);
            countNums(numA, numB, 5);
            countNums(numA, numB, 9);
        }
    }
}