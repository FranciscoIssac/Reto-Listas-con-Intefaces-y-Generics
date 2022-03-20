using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto_Listas_con_Interfaces_y_Generics
{
    internal class LinkedListIterator<T> : Iterator<T>
    {
        private Node<T> currentNode;

        public LinkedListIterator(Node<T> startNode)
        {
            currentNode = startNode;
        }

        public Boolean hasNext()
        {
            return currentNode != null;
        }

        public T next()
        {
            T data = currentNode.data;
            currentNode = currentNode.next;

            return data;
        }
    }
}
