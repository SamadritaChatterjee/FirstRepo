using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    internal class Class2
    {
        int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


        //using query:
        public void Display()
        {
            IEnumerable<int> result = from a in arr
                                      select a;

            foreach (int a in result)
            {
                Console.WriteLine($"{a}");
            }
        }

        public void Fun1()  //print even nos
        {
            var result = from a in arr
                         where a%2 == 0
                         select a;

            foreach (int a in result)
            {
                Console.WriteLine($"{a}");
            }
        }

        public void Fun2()
        {
            IEnumerable<int> result = from a in arr
                                     where a > 5
                                     select a;
            foreach (int a in result)
            {
                Console.WriteLine($"{a}");
            }
        }

        //using methods:
        public void LikeDisplay()
        {
            IEnumerable<int> result = arr.Select(a => a);
            foreach (int a in result)
            {
                Console.WriteLine($"{a}");
            }
        }

        public void LikeFun1()     //print even nos
        {
            IEnumerable<int> result = arr.Where(a => a % 2 == 0);
            foreach (int a in result)
            {
                Console.WriteLine($"{a}");
            }
        }

        public void LikeFun2()
        {
            IEnumerable<int> result = arr.Where(a => a > 5);

            foreach (int a in result)
            {
                Console.WriteLine($"{a}");
            }

        }
    }
}
