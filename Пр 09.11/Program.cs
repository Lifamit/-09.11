using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_09._11
{
    internal class Program
    {
        static int[,] RandArray(int[,] Mas)
        {
            Random W = new Random();
            for (int i = 0; i < Mas.GetLength(0); i++)
            {
                for (int j = 0; j < Mas.GetLength(1); j++)
                {
                    Mas[i, j] = W.Next(0, 10);
                }
            }
            return Mas;
        }
        static void PrintRaid2Mass(int[,] Mas)
        {
            Console.WriteLine("Матрица:");
            for (int i = 0; i < Mas.GetLength(0); i++)
            {
                for (int j = 0; j < Mas.GetLength(1); j++)
                {
                    Console.Write(Mas[i,j] + " ");
                }
                Console.WriteLine();
            }
            
        }
        static int[] SumsLineRaid2Array(int[,] Mas)
        {
            int[] masSumLine = new int[Mas.GetLength(0)];
            for (int i = 0; i < Mas.GetLength(0); i++)
            {
                for (int j = 0; j < Mas.GetLength(1); j++)
                {
                    masSumLine[j] += Mas[i, j];
                }
            }
            return masSumLine;
        }
        static void MinSumArray(int[] masSumLine)
        {
            int minsum = masSumLine.Min();
            for (int i = 0; i < masSumLine.Length; i++)
            {
                if(minsum  == masSumLine[i])
                Console.Write($"Минимальный индекс суммы столбцов матрицы: {i}");
            }
            Console.WriteLine();
        }
        static void PrintSumArray(int[] masSumLine)
        {
            for(int i = 0; i < masSumLine.Length; i++)
            {
                Console.Write(masSumLine[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк матрицы: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов матрицы: ");
            int y = int.Parse(Console.ReadLine());
            int[,] Mas = new int[x, y];
            Mas = RandArray(Mas);
            PrintRaid2Mass(Mas);
            int[] masSumLine = new int[y];
            masSumLine = SumsLineRaid2Array(Mas);
            Console.Write("Сумма столбцов массива: ");
            PrintSumArray(masSumLine);
            MinSumArray(masSumLine);
            Console.ReadKey();
        }
    }
}

