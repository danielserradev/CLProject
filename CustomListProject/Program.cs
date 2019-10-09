using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> actual;
            CustomList<string> list1 = new CustomList<string>();
            CustomList<string> list2 = new CustomList<string>();
            list1.Add("1");
            list1.Add("2");
            list2.Add("1");
            list2.Add("3");
            actual = list1 - list2;
            Console.ReadLine();
        }
    }
}
