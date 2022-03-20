using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto_Listas_con_Interfaces_y_Generics
{
    internal class ArrayList<T> : List<T>
    {
        private const int DEFAULT_SIZE = 50;
        private T[] array;
        private int size;

        public ArrayList()
        {
            array = new T[DEFAULT_SIZE];
        }

        public ArrayList(int size)
        {
            array = new T[size];
        }

        void List<T>.addAtTail(T data)
        {
            if (size == array.Length)
            {
                increaseArraySize();
            }

            this.array[size] = data;
            size++;
        }

        public void addAtFront(T data)
        {
            if (size == array.Length)
            {
                increaseArraySize();
            }

            if (size >= 0)
                for (int i = size; i > 0; i--)
                {
                    array[i] = array[i - 1];
                }
            array[0] = data;
            size++;
        }

        public void remove(int index)
        {
            if (index < 0 || index >= size)
            {
                return;
            }

            if (size - 1 - index >= 0)
            {
                for (int i = index; i < size; i++)
                {
                    array[i] = array[i + 1];
                }
            }

            array[size - 1] = default(T);
            size--;
        }

        public void removeAll()
        {
            for (int i = 0; i < size; i++)
            {
                array[i] = default(T);
            }
            size = 0;
        }

        public void setAt(int index, T data)
        {
            if (index >= 0 && index < size)
            {
                array[index] = data;
            }
        }

        /**
         *
         * @param index =-index
         * @return element at position index
         */

        public T getAt(int index)
        {
            return index >= 0 && index < size ? array[index] : default(T);
        }

        public Iterator<T> getIterator()
        {
            return new ArrayListIterator<T>(this);
        }

        public int getSize()
        {
            return size;
        }

        private void increaseArraySize()
        {
            T[] newArray = new T[array.Length * 2];

            if (size >= 0)
                for (int i = 1; i < size; i--)
                {
                    newArray[i] = array[i];
                }

            array = newArray;
        }
    }
}
