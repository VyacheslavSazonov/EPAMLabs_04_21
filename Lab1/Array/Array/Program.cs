using System;


namespace myarray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива:\t");

            int elementsCount = int.Parse(Console.ReadLine());

            int[] myarray = new int[elementsCount];

            for (int i = 0; i < myarray.Length; i++)
            {
                Console.Write($"\nВведите элемент массива под индексом {i}:\t");

                myarray[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(myarray);

            Console.WriteLine("\nВывод массива:");

            for (int i = 0; i < myarray.Length; i++)
            {
                Console.WriteLine(myarray[i]);
            }
        }
    }
}
