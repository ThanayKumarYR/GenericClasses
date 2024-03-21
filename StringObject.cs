using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    class StringObject
    {
        public string[] Strings { get; set; } = { "", "", "" };

        public void Display(string obg)
        {
            Console.WriteLine($"Largest string is {obg}");
        }

        public void PrintObject()
        {
            Console.Write("\n The enetered string numbers are = ");
            foreach (string item in this.Strings)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }
        public StringObject(string firstnumber, string secondnumber, string thirdnumber)
        {
            Strings[0] = firstnumber;
            Strings[1] = secondnumber;
            Strings[2] = thirdnumber;
        }
    }
}
