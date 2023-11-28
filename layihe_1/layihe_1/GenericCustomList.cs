using System;

namespace layihe_1
{
    public class GenericCustomList<T>
    {
        private T[] items;
        private int count;
        private int capacity;

        public int Count
        {
            get { return count; }
        }

        public int Capacity
        {
            get { return capacity; }
        }
        public GenericCustomList()
        {
            items = new T[0];
            count = 0;
            capacity = 0;
        }
        public void Add(T item)
        {
            if (count == capacity)
            {
                if (capacity == 0)
                    capacity = 4;
                else
                    capacity *= 2;

                T[] newItems = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    newItems[i] = items[i];
                }

                items = newItems;
            }

            items[count] = item;
            count++;
        }
        public T Find(Predicate<T> match)
        {
            return Array.Find(items, match);
        }



        public GenericCustomList<T> FindAll(Predicate<T> match)
        {
            Array.FindAll<T>(items , match);
            
            return this;
            

        }

        public bool Contains(T item)
        {
            return items.Contains(item);
        }



        public bool Exists(Predicate<T> match)
        {
            if (Array.Exists(items, match))
            {
                return true;
            }
            return false;
        }

        public void Remove(Predicate<T> match)
        {
            int newIndex = 0;
            for (int i = 0; i < count; i++)
            {
                if (!match(items[i]))
                {
                    items[newIndex] = items[i];
                    newIndex++;
                }
            }

            count = newIndex;
        }
    }   
}
