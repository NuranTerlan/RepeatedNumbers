using System;

namespace RepeatedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

                    //For Example we have this integer type array

            int[] array = { 1, 2, 4, 2, 9, 4, 2, 5, 6, 3, 7, 7, 8, 7, 1, 2, 5, 2, 6, 5 };

            for (int i = 0; i < array.Length; i++)
            {
                int temprepeated = 0;
                int count = 1;
                for (int j = 0; j < array.Length; j++)
                {
                    if (i != j && array[i] == array[j])
                    {
                        if (j < i)
                        {
                            break;
                        }
                        else
                        {
                            temprepeated = array[i];
                            count++;
                        }
                    }
                }
                if (temprepeated != 0)
                {
                    Console.WriteLine($"{temprepeated} this number is repe number in array, and repeat {count} times !");
                }
            }
        }
    }
}
