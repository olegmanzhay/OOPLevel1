using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace App1
{
    class Program
    {
        #region MyRegion
        /// <summary>
        /// Инициализация массива
        /// </summary>
        /// <param name="Data"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        static void FillArray(int[] Data, int min, int max)
        {
            Random rnd = new Random();
            for (int i = 0; i < Data.Length; i++)
            {
                Data[i] = rnd.Next(min, max);
            }
        }
        /// <summary>
        /// Сумма элементов массива
        /// </summary>
        /// <param name="Data"></param>
        /// <returns></returns>
        static int SumMass(int[] Data)
        {
            int sum = 0;
            foreach (var item in Data)
            {
                sum += item;
            }
            return sum;
        }
        #endregion

        static void Main(string[] args)
        {
            #region Array
            //int[] array1 = new int[10];
            //int[] array2 = new int[20];
            //int minValueArray;
            //int maxValueArray;

            //Console.WriteLine("Введите минимальное значение элемента массива: ");
            //minValueArray = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите максимальное значение элемента массива: ");
            //maxValueArray = int.Parse(Console.ReadLine());

            //FillArray(array1, minValueArray, maxValueArray);
            //FillArray(rarray2, minValueArray, maxValueArray);

            //for (int i = 0; i < array1.Length; i++)
            //{
            //    Console.Write($"{array1[i]} ");
            //}
            //Console.WriteLine();
            //foreach (var item in array2)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine($"Cумма элементов array1 составляет: {SumMass(array1)}");

            //var a = array1.Reverse();
            //Array.Sort(array2);
            //foreach (var item in array2)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();
            //Console.Write(string.Join(" ", a));
            //Console.ReadKey();
            #endregion
            Class1.SayHi();
            
            
        }
    }
}
