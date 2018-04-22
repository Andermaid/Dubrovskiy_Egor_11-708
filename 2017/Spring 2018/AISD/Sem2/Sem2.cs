using System;
using System.Linq;

namespace Sem2
{
    class Program
    {
        static void PigeonholeSort(int[] array)
        {
            //Вычисляем диапозон возможных значений.
            int max = array.Max();
            int min = array.Min();
            int range = max - min + 1;
            //Создаём массив temp и для каждого элемента значения i в temp[i - min] записываем количество его вхождений.
            int[] temp = new int[range];
            int count = array.Length;
            for (int i = 0; i < count; i++)
                temp[array[i] - min]++;
            //Переписываем изначальный массив.
            int b = 0;
            for (int i = 0; i < range; i++)
                for (int j = 0; j < temp[i]; j++)
                {
                    array[b] = i;
                    b++;
                }
        }

        static void Quicksort(int[] array)
        {
            if (array.Length > 1) Quicksort(array, 0, array.Length - 1);
        }

        static void Quicksort(int[] array, int left, int right)
        {
            if (left == right) return;
            int i = left + 1;
            int j = right;
            int pivot = array[left];
            while (i < j)
            {
                if (array[i] <= pivot) i++;
                else if (array[j] > pivot) j--;
                else
                {
                    int m = array[i]; array[i] = array[j]; array[j] = m;
                }
            }
            if (array[j] <= pivot)
            {
                int m = array[left]; array[left] = array[right]; array[right] = m;
                Quicksort(array, left, right - 1);
            }
            else
            {
                Quicksort(array, left, i - 1);
                Quicksort(array, i, right);
            }
        }
    }
}
