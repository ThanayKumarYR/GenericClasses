using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    class IntegerObject
    {
        public int[] Number { get; set; } = { 0, 0, 0 };

        public void Display(int num)
        {
            Console.WriteLine($"Largest number is {num}");
        }

        public IntegerObject(int firstnumber,int secondnumber,int thirdnumber)
        {
            Number[0] = firstnumber;
            Number[1] = secondnumber;
            Number[2] = thirdnumber;
        }

    }
}
