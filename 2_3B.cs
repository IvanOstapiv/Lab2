using System;

namespace Lab2_3T
{
    public class Program
    {

        static public int Mi_P(int[] a, int n) //підпрограмма, яка шукає мінімальне число і його індекс;
        {
            int min = a[0];
            for (int i = 0; i < n; ++i) //Шукаєм мінімальне число;
            {
                if (a[i] < min)
                    min = a[i];
            }
            int mi = 0;
            for (int i = 0; i < n; ++i) //Шукаєм інденкс мінімального числа;
            {
                if (min == a[i])
                {
                    mi = i;
                }

            }
            return mi; //Повертаєм інденкс мінімального числа;
        }
        static public int Dob_P(int[] a, int n) //підпрограмма, яка множить числа до першого нульового елемента;
        {
            int dob = 1, zero1 = 998, in_zero = 999;
            for (int i = 0; i < n; ++i)  //Шукаєм "нуль" елемент;
            {
                if (a[i] == 0)
                {
                    zero1 = a[i];
                }
            }
            for (int i = 0; i < n; ++i) //Шукаєм індекс "нуль" елемента;
            {
                if (zero1 == a[i])
                {
                    in_zero = i;
                }
            }
            if (zero1 == 998 && in_zero == 999) //якщо нуля немає, то прирівнюєм наш dob = 0;
            {
                dob = 0;
            }
            else //якщо є нуль то просто рахуєм добуток;
            {
                for (int i = 0; i < in_zero; ++i)
                {
                    dob *= a[i];
                }
            }
            return dob; //повертаєм добуток;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введiть кiлькiсть елементiв масиву");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Random rand1 = new Random(); // Ranmom називаєм rand1;
            for (int i = 0; i < n; ++i)
            {
                a[i] = rand1.Next(-100, 100);  //виводим рандомні числа
                Console.WriteLine("a[" + i + "]="+a[i]);
               
            }
            int mi = Mi_P(a, n); //підпрограмма, яка шукає мінімальне число і його індекс;
            int dob = Dob_P(a, n); //підпрограмма, яка множить числа до першого нульового елемента;
            if (dob == 0) //якщо ми "dob" присвоїли нулю(46ст), то у масивi немає нулiв;
            {
                Console.WriteLine("У масивi немає нулiв");
            }
            else //якщо є нуль, то виводим наш добуток;
            {
                Console.WriteLine("Добуток всiх елементiв до першого нульового елемента = " + dob);
            }
            Console.WriteLine("Номер мiнiмального елемента масиву = " + mi); //індекс мін числа;
        }
    }
}
