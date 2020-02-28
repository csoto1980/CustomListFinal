using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(2);
            numbers.Add(4);
            numbers.Add(6);
            numbers.Add(8);
            numbers.Add(10);

            numbers.Remove(6);
        }

        //public int OverloadPlus(List<int>, List<int>)
        //{

        //}
      
        //List<int> one = new List<int> { 1, 3, 5 };
        //List<int> two = new List<int> { 2, 1, 6 };
        //List<int> result = one + two;

        //Console.ForegroundColor = ConsoleColor.Cyan;
    }
}
