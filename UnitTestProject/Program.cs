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
            string actual;
            List<string> list1 = new List<string>() { "1", "2" };
            List<string> list2 = new List<string>() { "1", "3" };
            list1.ToString();
            list2.ToString();
            actual = (list1 - list2).ToString();
            Console.ReadLine();
        }
    }
}
