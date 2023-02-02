using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region #1 Поменять местами строки с минимальными кол-вом элементов с максимальным кол-вом. Кол-во элементов в каждой строке - случ. число.'
            //int max_elements_index = 0, min_elements_index = 1000;
            //Random random = new Random();
            //int[][] arr = new int[5][];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = new int[random.Next(2, 5)];
            //    if (max_elements_index < arr[i].Length) max_elements_index = i;
            //    if (min_elements_index > arr[i].Length) min_elements_index = i;
            //}


            //Console.WriteLine("Initial array: ");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        arr[i][j] = random.Next(10,99);
            //        Console.Write("{0,4}", arr[i][j]);
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("Max elements index - " + max_elements_index + "\nMin elements index - " + min_elements_index);
            //int[] buffer = arr[max_elements_index];
            //arr[max_elements_index] = arr[min_elements_index];
            //arr[min_elements_index] = buffer;
            //Console.WriteLine();

            //Console.WriteLine("Row " + max_elements_index + " and " + min_elements_index + " were swaped!:");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.Write("{0,4}", arr[i][j]);
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            #endregion
            #region #2 Создать зубчатый массив ступенчатого вида.
            //int[][] arr = new int[4][]
            //{
            //   new int[6] {0,0,0,0,0,0},
            //   new int[5] {0, 0, 0, 0, 0},
            //   new int[4] {0,0,0,0},
            //   new int[2] {0,0}
            //};
            //Console.WriteLine("Initial array: ");
            //Random random= new Random();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        arr[i][j] = random.Next(10, 99);
            //        Console.Write("{0,4}", arr[i][j]);
            //    }
            //    Console.WriteLine();
            //}
            #endregion
        }
    }
}
