
// Программа 3 - определение типа треугольника по длинам его сторон

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            string str;
            int[] sides = null;
            int sideA = 0;
            int sideB = 0;
            int sideC = 0;

            do
            {
                try
                {
                    System.Console.Write("Введите стороны треугольника (через пробел): ");
                    str = Console.ReadLine();
                    if (str != null)
                    {
                        sides = str.Split().Select(s => int.Parse(s)).ToArray();
                        if (sides.Length == 3)
                        {
                            sideA = sides[0];
                            sideB = sides[1];
                            sideC = sides[2];
                            flag = true;
                        }
                        else
                            Console.WriteLine("Количество сторон не равно трём. Повторите ввод");
                    }
                    else
                        Console.WriteLine("Введена пустая строка. Повторите ввод");
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine("Некорректные значения. Повторите ввод");
                }
            } while (!flag);

            if (sideA == sideB && sideB == sideC)
                Console.WriteLine("Треугольник - равносторонний");
            else if (sideA == sideB || sideB == sideC || sideA == sideC)
                Console.WriteLine("Треугольник - равнобедренный");
            else if (Math.Pow(sideA, 2) == Math.Pow(sideB, 2) + Math.Pow(sideC, 2) ||
                    Math.Pow(sideB, 2) == Math.Pow(sideA, 2) + Math.Pow(sideC, 2) ||
                    Math.Pow(sideC, 2) == Math.Pow(sideA, 2) + Math.Pow(sideB, 2))
                Console.WriteLine("Треугольник - прямоугольный");
            else
                Console.WriteLine("Треугольник - обычный");

        }
    }
}