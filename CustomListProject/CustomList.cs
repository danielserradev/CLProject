using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {
        private T[] items;

        public CustomList()
        {
            items = new T[4];
        }
        
        public T this[int i]
        {
            get { return items[i]; }
            set { items[i] = value; }
        }
        public void Add(T itemToAdd)
        {
         
            CustomList<T> customList = new CustomList<T>();
            for (int i = 0; i < items.Length; i++)
            {
                customList[i] = itemToAdd;
            }

        }

    }
}
