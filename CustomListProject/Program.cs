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
            var numCounter = new CustomList<int>();
            numCounter.Add(1);
            numCounter.Add(2);
            numCounter.Add(3);
            numCounter.Add(4);
            numCounter.Add(5);
            Console.WriteLine(numCounter[0]);
            Console.WriteLine(numCounter[1]);
            Console.WriteLine(numCounter[2]);
            Console.WriteLine(numCounter[3]);
            Console.WriteLine(numCounter[4]);


            Console.ReadLine();
        }
    }
}
