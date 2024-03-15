using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("VARIANT 1\n");
        Console.WriteLine("Створити масив..");
        Console.WriteLine("Введiть розмір масиву: ");
        string str_size = Console.ReadLine();
        Console.WriteLine("Введiть мінімальну межу: ");
        string str_min = Console.ReadLine();
        Console.WriteLine("Введiть максимальну межу: ");
        string str_max = Console.ReadLine();
        int size = int.Parse(str_size);
        int min = int.Parse(str_min);
        int max = int.Parse(str_max);


        ArrayManipulator manipulator = new ArrayManipulator();
        int[] array = manipulator.GenerateRandomArray(size, min, max);
        manipulator.PrintArray(array);

        Console.WriteLine("Сортувати масив..");
        manipulator.SortArray(array);
        manipulator.PrintArray(array);

        Console.WriteLine("Найти макс число..");
        Console.WriteLine(manipulator.FindMax(array));
    }

    class ArrayManipulator
    {
        public void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
        }

        public int[] GenerateRandomArray(int length, int min, int max)
        {
            int[] result = new int[length];
            System.Random random = new System.Random();

            for (int i = 0; i < length; i++)
            {
                int num = random.Next(min, max);
                result[i] = num;
            }
            return result;
        }

        public int FindMax(int[] array)
        {
            int max = 0;

            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

        public int[] SortArray(int[] array)
        {
            Array.Sort(array);

            return array;
        }
    }
}
