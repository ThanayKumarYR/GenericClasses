using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    class StringObject
    {
        public List<string> Strings { get; set; } = new List<string>();

        public void Display(string obg)
        {
            Console.WriteLine($"Largest string is {obg}");
        }

        public void PrintObject()
        {
            Console.Write("\n The enetered strings are = ");
            foreach (string item in this.Strings)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }
        public StringObject(params string[] strings)
        {
            foreach (var item in strings)
            {
                Strings.Add(item);
            }
        }
    }
}
