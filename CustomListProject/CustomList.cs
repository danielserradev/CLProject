using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {
        private T[] tempArray;
        private T[] items;
        public int capacity = 4;
        public int Count = 0;

        public CustomList()
        {
            items = new T[capacity];
            tempArray = new T[capacity];
        }
        
        public T this[int i]
        {
            get { return items[i]; }
            set { items[i] = value; }
        }
        
        
        public void Add(T itemToAdd)
        {
            items[Count] = itemToAdd;
            Count++;

            if(Count == capacity)
            {
                
                tempArray = items;        
                capacity = capacity * 2;
                items = new T[capacity];
                for (int i = 0; i < Count; i++)
                {
                    items[i] = tempArray[i];
                }
                items[Count] = itemToAdd;
                
            }
            else
            {

            }

        }

    }
}
