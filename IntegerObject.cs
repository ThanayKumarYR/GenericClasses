using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    class IntegerObject
    {
        public List<int> Number { get; set; } = new List<int>();

        public void Display(int num)
        {
            Console.WriteLine($"Largest integer is {num}");
        }

        public void PrintObject()
        {
            Console.Write("\n The enetered interger numbers are = ");
            foreach (float item in this.Number)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }

        public IntegerObject(params int[] ints) 
        {
            foreach (int item in ints)
            {
                Number.Add(item);
            }
        }

    }
}
