using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace massiv
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*         //объявление одномерного массива с исп. конструктора new
             int[] massive = new int[6];
                     //заполнение массива 
                     for (int i = 0; i < massive.Length; i++)
             {
                 Write($"massive[{i}] = ");
                 massive[i] = Convert.ToInt32(ReadLine());

             }
             for (int i = 0; i < massive.Length; i++)
             {
                 WriteLine($"massive[{i}] = {massive[i]}");
             }*/

            // задача 2

            /*int[] num = new int[] { 3, 4, 6, 7, -18, 6 };
            foreach (int i in num) 
            {
                Write($"{i}\t");
            }*/

            // задача 3
           
            
                Write("введите длину массива n = ");
                int n = int.Parse(Console.ReadLine());
                int[] mas = new int[n];
                Random rnd = new Random();
                int i;
            for (i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(mas.Length);
                WriteLine($"mas{i} = {mas[i]}");
            }
            
            ReadKey();
        }
    }
}
