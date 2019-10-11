using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T> : IEnumerable
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

        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < Count; i++)
            {
                yield return items[i];
            }
        }


        public T this[int i]
        {
            get
            {
                if (i > Count - 1)
                {              
                    throw new System.ArgumentOutOfRangeException("index parameter is out of range.");
                                       
                }
                return items[i];
            }
            set { items[i] = value; }
        }


        public void Add(T itemToAdd)
        {
            items[Count] = itemToAdd;
            Count++;
            if (Count == capacity)
            {

                tempArray = items;
                capacity = capacity * 2;
                items = new T[capacity];
                for (int i = 0; i < Count; i++)
                {
                    items[i] = tempArray[i];
                }                
            }
            
        }
        public bool Remove(T itemToRemove)
        {
            for(int i = 0; i < Count; i++)
            {
                if (items[i].Equals(itemToRemove))
                {
                    Count--;
                    for(int j = i; j < Count + 1; j++)
                    {
                        items[j] = items[j + 1];
                    }
                    return true;
                }
                else
                {
                    items[i] = items[i];
                }
            }           
            return false;
        }
        public string results;
        public override string ToString()
        {
            if (Count == 1)
            {
                for (int i = 0; i < Count; i++)
                {
                    results = items[i].ToString();
                }
            }
            else
            {
                for (int i = 0; i < Count; i++)
                {
                    if (i == Count - 1)
                    {
                        results += items[i].ToString();
                    }
                    else
                    {
                        results += items[i].ToString() + ", ";
                    }
                }
            }
            return results;
        }

       

        public static CustomList<T> operator + (CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> list3 = new CustomList<T>();
            for (int i = 0; i < list1.Count; i++)
            {
                list3.Add(list1[i]);
            }
            for (int i = 0; i < list2.Count; i++)
            {
                list3.Add(list2[i]);
            }
            return list3;
        }
        public static CustomList<T> operator - (CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> tempList1 = list1 + new CustomList<T>();
            for (int i = 0; i < list2.Count; i++)
            {
                tempList1.Remove(list2[i]);
                
            }
            


            return tempList1;
        }
        public CustomList<T> Zip(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> list3 = new CustomList<T>();


            for (int i = 0; i < list1.Count; i++)
            {
                list3.Add(list1[i]);
                list3.Add(list2[i]);
                
                
                
            }

            return list3;
        }
        public void GetShortesList()
        {

        }
    }
}
