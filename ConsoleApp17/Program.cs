using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //з1

            //int[] myArray = new int[6];

            //for (int i = 0; i < 6; i++)
            //{
            //    Console.Write($"Введите элемент myArray[{i}]: ");
            //    myArray[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine($"myArray[{i}]= {myArray[i]}");
            //}
            //з2
            //Random random = new Random();
            //int[] randomArray = new int[random.Next(0, 100)];
            //int i;
            //for ( i = 0; i < randomArray.Length; i++)
            //{
            //    randomArray[i] = random.Next(1, 101); 
            //}
            //for (i = 0; i < randomArray.Length; i++)
            //{
            //    Console.WriteLine($"randomArray[{i}]= {randomArray[i]}");
            //}
            //з3
            //Console.Write("Введите количество элементов:");
            //int n = int.Parse(Console.ReadLine());
            //double[] massive = new double[n];
            //for (int i = 0;i<n;i++)
            //{
            //    massive[i] = Math.Pow(i, 2);
            //    Console.WriteLine($"massive[{i}]= {massive[i]}");
            //}
            //з4
            Random random = new Random();
            Random random1 = new Random();
            int[] randomArray = new int[random1.Next(1,10)];

            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = random.Next(1, 101); 
            }
            Console.WriteLine("Случайно заполненный массив:");
            foreach (int item in randomArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
