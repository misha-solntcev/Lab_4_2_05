using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  5. Задан массив D[1..10]. Сформировать два массива, включая 
    в первый элементы исходного массива с четными индексами, 
    а во второй - с нечетными индексами.*/

namespace Lab_4_2_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] D = new int[20];
            Random rand = new Random();
            for (int i = 0; i < D.Length; i++)
            {
                D[i] = rand.Next(-10, 10);
                Console.Write(D[i] + " ");
            }
            Console.WriteLine("\n");

            int[] Even = new int[D.Length / 2]; // Новый массив чисел с четными индексами
            int[] Odd = new int[D.Length / 2];  // Новый массив чисел с нечетными индексами
            int count_Even = 0;              // Счетчик четных b 
            int count_Odd = 0;              // Счетчик нечетных
            for (int i = 0; i < D.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Even[count_Even] = D[i]; 
                    count_Even++;
                }                    
                if (i % 2 != 0)
                {
                    Odd[count_Odd] = D[i]; 
                    count_Odd++;                                                    
                }                    
            }
            foreach (var item in Even)
                Console.Write(item + " ");
            Console.WriteLine();
            foreach (var item in Odd)
                Console.Write(item + " ");
            Console.WriteLine("\n");

            // С помощью расширений Linq
            var Even_L = D.Where((d,i) => i % 2 == 0);
            foreach (var item in Even_L)
                Console.Write(item + " ");
            Console.WriteLine();
            var Odd_L = D.Where((d, i) => i % 2 != 0);
            foreach (var item in Odd_L)
                Console.Write(item + " ");

            Console.ReadLine();
        }
    }
}
