using System;

namespace _2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Введите день недели");
            x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1: Console.WriteLine("Понедельник\n c 8 до 10"); break;
                case 2: Console.WriteLine("Вторник\n Не работает"); break;
                case 3: Console.WriteLine("Среда\n Не работает"); break;
                case 4: Console.WriteLine("Четверг\n Не работает"); break;
                case 5: Console.WriteLine("Пятница\n Не работает"); break;
                case 6: Console.WriteLine("Суббота\n Не работает"); break;
                case 7: Console.WriteLine("Воскресенье\n Не работает"); break;
                default: Console.WriteLine("Вы ошиблись"); break;
            }
        }
    }
}
