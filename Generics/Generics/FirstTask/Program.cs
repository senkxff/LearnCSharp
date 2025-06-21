using System;
using System.Runtime.CompilerServices;

namespace FirstTask
{
    /*
     * Напишите обобщенный класс, который может хранить в массиве объекты любого типа. Кроме того, данный класс 
     * должен иметь методы для добавления данных в массив, удаления из массива, получения элемента из массива 
     * по индексу и метод, возвращающий длину массива.
     * Для упрощения работы можно пересоздавать массив при каждой операции добавления и удаления.
     */

    class WorkWithArray<T>
    {
        private int elementsCount;
        private T[]? array;

        public WorkWithArray()
        {
            array = new T[elementsCount];
        }

        public void AddElements(params T[] elements)
        {
            if (elementsCount < elements.Length)
            {
                elementsCount = elements.Length;
                array = new T[elementsCount];
            }

            for (int i = 0; i < elements.Length; i++)
            {
                array[i] = elements[i];
            }
        }

        public void DeleteElements(T element)
        {
            int position = -1;
            T[] tempArray = new T[elementsCount - 1];
 
            for (int i = 0; i < elementsCount; i++)
            {
                if (array[i].Equals(element))
                {
                    position = i;
                    break;
                }
            }

            for (int i = 0, j = 0; i < elementsCount; i++)
            {
                if (i == position) continue; 

                tempArray[j] = array[i];
                j++;
            }

 
            array = tempArray;
        }

        public void GetLength()
        {
            Console.WriteLine($"Длина массива составляет: {array.Length}");
        }

        public void FindElement(int index = -1)
        {
            if (index != -1)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (i == index)
                    {
                        Console.WriteLine($"Элемент на позиции {index} - это {array[i]}");
                    }
                }
            }
        }

        public void ShowArray()
        {
            foreach(T element in array)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            WorkWithArray<int> wwa = new WorkWithArray<int>();

            wwa.AddElements(1, 2, 3, 4, 5);
            wwa.ShowArray();
            wwa.GetLength();

            wwa.DeleteElements(3);
            wwa.ShowArray();
            wwa.GetLength();

            wwa.FindElement(2);
        }
    }
}