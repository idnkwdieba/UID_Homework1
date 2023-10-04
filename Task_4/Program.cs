
// Программа 4 - вывод степеней числа 2 от 0 до 20

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            System.Console.WriteLine("Степени числа 2:");
            while (i <= 20)
            {
                System.Console.WriteLine("{0,-5}: {1}", ("2^"+i), Math.Pow(2, i));
                i++;
            }
        }
    }
}