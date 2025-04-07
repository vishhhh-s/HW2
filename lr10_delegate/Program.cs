using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lr10_delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(Random.Shared.Next(-50, 50));
            }
            Console.WriteLine("Список чисел:");
            Console.WriteLine(string.Join(",", list));

            Console.WriteLine("Выберите способ фильтрации");
            Console.WriteLine("1-Остаются чётные числа");
            Console.WriteLine("2-Остаются нечётные числа");
            Console.WriteLine("3-Остаются числа больше 10");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Filter(number=>number % 2 == 0, list);
                    break;
                case "2":
                    Filter(number=>number % 2 != 0, list);
                    break;
                case "3":
                    Filter(number => number>10, list);
                    break;
                default:
                    Console.WriteLine("Неверный выбор");
                    break;
            }
        }
        static void Filter(Predicate<int> predicate, List<int> list)
        {
            foreach (int number in list)
            {
                if (predicate(number))
                    Console.Write(number + " ");
            }
        }
    }
}
