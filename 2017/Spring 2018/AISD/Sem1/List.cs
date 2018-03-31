using System;
using System.Collections.Generic;

namespace Sem1
{
    class List<T>: IEnumerable<T>
    {
        public Node<T> Head;
        public Node<T> Tail;

        public int Count { get; set; }

        public IEnumerator<T> GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public T this[int index]
        {
            get
            {
                if (index < 0) throw new ArgumentOutOfRangeException();
                Node<T> current = Head;
                for (int i = 0; i < index; i++)
                {
                    if (current.Next == null)
                        throw new ArgumentOutOfRangeException();
                    current = current.Next;
                }
                return current.Value;
            }
        }
        
        public void AddInside(T value, int index)
        {
            if (index > Count || index < 0)
                throw new ArgumentOutOfRangeException();
            if (index == 0)
                AddFirst(value);
            else if (index == (Count - 1))
                Add(value);
            else
            {
                Node<T> currentNode = Head;
                for (int i = 0; i < index - 1; i++)
                {
                    currentNode = currentNode.Next;
                }
                Node<T> node = new Node<T>(value, currentNode.Next);
                currentNode.Next = node;
                Count++;
            }
        }

        public void AddFirst(T value)
        {
            Node<T> node = new Node<T>(value);
            Node<T> temp = Head;
            node.Next = temp;
            Head = node;
            if (Count == 0)
            {
                Tail = Head;
            }
            else
            {
                temp.Previous = node;
            }
            Count++;
        }

        public void Add(T value)
        {
            Node<T> node = new Node<T>(value);
            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
            }
            Tail = node;
            Count++;
        }

        public T Remove(int index)
        {
            if (index > Count || index < 0)
                throw new ArgumentOutOfRangeException();
            T removedData;
            Node<T> current = Head;
            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }
            removedData = current.Value;
            current.Next = current.Next.Next;
            Count--;
            return removedData;
        }
    }
}