using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ques- Display those names from array where name starts with S and length is more than 5
namespace LINQDemo
{
    internal class Class1
    {
        string[] arr = new string[3] { "Sam", "Samadrita", "Tina" };
        public void Func() 
        { 
        

        IEnumerable<string> result = from a in arr
                                     select a;

        foreach(string a in result)
        {
            Console.WriteLine($"Array elements are: {a}");
        }
        }

        public void Show()
        {
            IEnumerable<string> result = arr.Where(a => a.Length > 5 && a.StartsWith("S"));
            foreach (string a in result)
            {
                Console.WriteLine($"{a}");
            }
        }

    }
}
