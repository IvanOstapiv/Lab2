using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть номер варiанта студента");
            int nomer = int.Parse(Console.ReadLine());
            switch(nomer)
            {
                case 1: Console.WriteLine("Бензар Олександр"); break;
                case 2: Console.WriteLine("Беркоша Микола"); break;
                case 3: Console.WriteLine("Бинда Роман"); break;
                case 4: Console.WriteLine("Борлодян Віталiй"); break;
                case 5: Console.WriteLine("Велущак Iгор"); break;
                case 6: Console.WriteLine("Гакман Олексiй"); break;
                case 7: Console.WriteLine("Герман Андрiй"); break;
                case 8: Console.WriteLine("Горенко Iван"); break;
                case 9: Console.WriteLine("Іванiн Олександр"); break;
                case 10: Console.WriteLine("Кобель Валентин"); break;
                default:Console.WriteLine("Такого варiанта немає"); break;
            }
        }
    }
}
