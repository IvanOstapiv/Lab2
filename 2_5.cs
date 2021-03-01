using System;

namespace Lab2_5
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введiть кiлькiсть стовбцiв");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть кiлькiсть рядкiв");
            int m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            Random rand1 = new Random(); // Ranmom називаєм rand1;
            for (int i = 0; i < n; ++i) //n стовбчик
                for (int j = 0; j < m; ++j) // m рядок
                {
                    a[i, j] = rand1.Next(-100, 100); //виводим рандомні числа
                    Console.Write("a[" + i + "]" + "[" + j + "]=" + a[i, j]+"\t");
                    Console.WriteLine("");
                }
            int[] b = new int[n];
            for (int i = 0; i < n; ++i)
                b[i] = 999;
                for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                {
                    if (a[i, j] < b[i]) //шукаєм найменше число в матриці;
                    {
                        b[i] = a[i, j];
                    }
                }
            int suma = 0; //Створюєм змінну, щоб додати всі мін. числа;
            for (int i = 0; i < n; ++i)
            {
                suma += b[i];
            }
            Console.WriteLine("\nСума всiх елементiв = " + suma); //Finish;
        }
    }
}
