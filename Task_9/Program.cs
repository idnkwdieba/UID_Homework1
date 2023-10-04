
// Программа 9 - подбрасывание монеты 100 раз

namespace Task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int heads = 0;
            int tails = 0;

            Console.WriteLine("Монета подбрасывается 100 раз");
            for (int i = 0; i < 100; i++)
            {
                _ = rand.Next(0,2) == 0 ? heads++ : tails++;
            }
            Console.WriteLine("Орел выпал {0} раз(-а), решка - {1} раз(-а)", heads, tails);
        }
    }
}