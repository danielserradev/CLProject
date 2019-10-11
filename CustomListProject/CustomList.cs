using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T> : IEnumerable where T: IComparable
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
  
        public override string ToString()
        {
            string results =  "";
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
            if(list1.Count == list2.Count)
            {
                for (int i = 0; i < list1.Count; i++)
                {
                    list3.Add(list1[i]);
                    list3.Add(list2[i]);                    
                }
            }
            else if(list1.Count > list2.Count)
            {
                for (int i = 0; i < list1.Count; i++)
                {
                    list3.Add(list1[i]);
                    if (list2.Count - 1 >= i)
                    {
                        list3.Add(list2[i]);
                    }
                }
            }
            else if (list1.Count < list2.Count)
            {
                for (int i = 0; i < list2.Count; i++)
                {                    
                    if (list1.Count - 1 >= i)
                    {
                        list3.Add(list1[i]);
                    }
                    list3.Add(list2[i]);
                }
            }
            return list3;
        }
        public void Sort ()
        {
            CustomList<int> list = new CustomList<int>();
            foreach (T item in items)
            {
                list.Add(Convert.ToInt32(item));
                
            }

            int temp;
            for (int i = 0; i <= list.Count - 2; i++)
            {
                for (int j = 0; j <= list.Count - 2; j++)
                {
                    if (list[i] > list[i + 1])
                    {
                        temp = list[i + 1];
                        list[i + 1] = list[i];
                        list[i] = temp;
                    }

                }


            }
            

        }
        //Compare(<T> items, <T> items )


    }
}
