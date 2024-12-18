using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackConsole.Core
{
    public class FixedStack<T> 
    {
        private T[] items; // элементы
        public int count;  // колво
        const int n = 1;   //Колво по стандарту


        public FixedStack()
        {
            items = new T[n];
        }

        public FixedStack(int length)
        {
            items = new T[length];
        }



        public bool IsEmpty
        {
            get { return count == 0; }
        }


        //Добавление
        public void Push(T item)
        {
            if (count == items.Length)
            {
                Resize(items.Length + 1);
            }
            items[count++] = item;
        }

        // Это типо удаление
        public T Pop()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Cтек пуст");
            }
            //throw new InvalidOperationException("Стек пуст");
            else
            {
                T item = items[--count];
                items[count] = default(T);
                return item;
            }
            return default(T);
        }

        //вывод
        public T Peek()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Cтек пуст");
            }
            //throw new InvalidOperationException("Стек пуст");
            else 
            { 
                return items[count - 1];
            }
            return default(T);
        }

        //Увелечение в случае если он переполнеен
        private void Resize(int max)
        {
            T[] tempItems = new T[max];
            for (int i = 0; i < count; i++)
            {
                tempItems[i] = items[i];
            }
            items = tempItems;
        }

        //Это типо вывод последнего Айтема
        public void LastItem()
        {
            int i = count - 1;
            T item = items[i];
            Console.WriteLine($"{item}");
        }

        //Это типо вывод первого Айтема
        public void FirstItem()
        {
            T item = items[0];
            Console.WriteLine($"{item}");
        }
    }
}
